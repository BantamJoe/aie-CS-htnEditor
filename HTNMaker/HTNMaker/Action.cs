using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    class Action
    {
        private string name;
        public string Name {
            get { return name; }
            set
            {
                // TODO somewhere, check name is unique
                name = Name;
            }
        }

        public string Description;

        private bool primitive;

        public bool IsPrimitive
        {
            get { return primitive; }
        }

        private List<Statement> conditions;

        public IReadOnlyCollection<Statement> Conditions
        {
            get { return conditions.AsReadOnly(); }
        }

        private List<Statement> effects;
        public IReadOnlyCollection<Statement> Effects
        {
            get { return effects.AsReadOnly(); }
        }

        private List<Action> children;
        public IReadOnlyCollection<Action> Children
        {
            get { return children.AsReadOnly(); }
        }

        public Action(string name, string description = "", bool primitive = false)
        {
            this.name = name;
            this.Description = description;
            conditions = new List<Statement>();
            effects = new List<Statement>();
            children = new List<Action>();
        }

        // Sets 
        public bool setPrimitive(bool primitive)
        {
            if(children.Count == 0)
            {
                this.primitive = primitive;
                return true;
            } else
            {
                return false;
            }
        }

        // TODO addChild: check if valid to add, not creating a loop, not already in children
        // TODO enumerate error codes?
        public int addChild(Action action)
        {
            if (primitive)
            {
                return 1; // 1 for primitive actions have no children
            }
            else if (children.Contains(action))
            {
                return 2; // 2 for child already exists
            } else if (action == this || isDescendant(action))
            {
                return 3; // 3 for possible loop
            } else
            {
                children.Add(action);
                return 0;
            }

        }
        // TODO removeChild
        // TODO addCondition/effect, if already in list just change value
        public void addCondition(Variable variable, bool value)
        {
            int index = conditions.FindIndex((Statement s) => { return s.Variable == variable; });
            if(index == -1)
            {
                conditions.Add(new Statement(variable, value));
            } else
            {
                conditions[index].Value = value;
            }
        }

        public void addEffect(Variable variable, bool value)
        {
            int index = effects.FindIndex((Statement s) => { return s.Variable == variable; });
            if (index == -1)
            {
                effects.Add(new Statement(variable, value));
            }
            else
            {
                effects[index].Value = value;
            }
        }

        //TODO remove condition/effect

        //TODO createDTO
        public ActionDTO CreateDTO()
        {
            ActionDTO dto = new ActionDTO();
            dto.Name = name;
            dto.Description = Description;
            dto.IsPrimitive = primitive;
            foreach (Statement condition in conditions)
            {
                dto.Conditions.Add(condition.CreateDTO());
            }
            foreach (Statement effect in effects)
            {
                dto.Effects.Add(effect.CreateDTO());
            }
            foreach (Action child in children)
            {
                dto.Children.Add(child.Name);
            }

            return dto;
        }

        public bool isDescendant(Action action)
        {
            if (children.Contains(action))
            {
                return true;
            } else
            {
                foreach(Action child in children)
                {
                    if (child.isDescendant(action))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
