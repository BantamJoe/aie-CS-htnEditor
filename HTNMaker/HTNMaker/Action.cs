using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    public class Action
    {

        private string name;
        public string Name {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Description { get; set; }

        private bool primitive;

        public bool IsPrimitive
        {
            get { return primitive; }
            set
            {
                if (children.Count == 0)
                {
                    this.primitive = value;
                } else
                {
                    this.primitive = false;
                }
            }
        }
        

        public bool HasNoChildren
        {
            get { return children.Count == 0; }
        }

        private List<Statement> conditions;

        //public IReadOnlyCollection<Statement> Conditions
        //{
        //    get { return conditions.AsReadOnly(); }
        //    set { }
        //}
        public List<Statement> Conditions
        { get { return conditions; }
        set { conditions = value; }
        }

        private List<Statement> effects;
        public List<Statement> Effects
        {
            get { return effects; }
            set { effects = value; }
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
        
        public void removeChild(Action action)
        {
            children.Remove(action);
        }

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
        public void removeCondition(Variable variable)
        {
            conditions.RemoveAll(condition => condition.Variable == variable);
        }

        public void removeEffect(Variable variable)
        {
            effects.RemoveAll(effect => effect.Variable == variable);
        }

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
