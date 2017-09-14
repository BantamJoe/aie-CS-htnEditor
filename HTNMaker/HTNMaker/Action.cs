using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        
        public bool IsNotPrimitive
        { get { return !primitive; } }

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

        private ObservableCollection<Action> children;
        private ReadOnlyObservableCollection<Action> readOnlyChildren;
        public ReadOnlyObservableCollection<Action> Children
        {
            get { return readOnlyChildren; }
        }

        private List<Action> parents;

        public IReadOnlyCollection<Action> Parents
        {
            get { return parents.AsReadOnly(); }
        }

        private bool descendantsDirty;

        private HashSet<Action> descendants;

        public HashSet<Action> Descendants
        {
            get
            {
                if (descendantsDirty)
                {
                    descendants.Clear();
                    foreach (Action child in children)
                    {
                        descendants.Add(child);
                        descendants.UnionWith(child.Descendants);
                    }
                    descendantsDirty = false;
                }
                return descendants;
                
            }
        }

        public Action(string name, string description = "", bool primitive = false)
        {
            this.name = name;
            this.Description = description;
            conditions = new List<Statement>();
            effects = new List<Statement>();
            children = new ObservableCollection<Action>();
            readOnlyChildren = new ReadOnlyObservableCollection<Action>(children);
            parents = new List<Action>();
            descendantsDirty = true;
            descendants = new HashSet<Action>();
        }

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
            } else if (action == this || action.Descendants.Contains(this))
            {
                return 3; // 3 for possible loop
            } else
            {
                children.Add(action);
                action.parents.Add(this);
                flagDirtyDescendants();
                return 0;
            }

        }
        
        public void removeChild(Action action)
        {
            flagDirtyDescendants();
            children.Remove(action);
            action.parents.Remove(this);
        }

        private void flagDirtyDescendants()
        {
            descendantsDirty = true;
            foreach(Action parent in parents)
            {
                parent.flagDirtyDescendants();
            }
        }

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
    }
}
