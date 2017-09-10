using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    public class Model
    {
        private List<Action> actions;
        private List<Variable> variables;
        private List<Action> topLevelActions;

        //TODO fields
        public List<Action> Actions
        {
            get
            {
                return actions;
            }
            set
            {
                actions = value;
            }
        }
        public List<Variable> Variables
        {
            get
            {
                return variables;
            }
            set
            {
                variables = value;
            }
        }
        private List<Action> TopLevelActions
        {
            get
            {
                return topLevelActions;
            }
            set
            {
                topLevelActions = value;
            }
        }

        public Model()
        {
            actions = new List<Action>();
            variables = new List<Variable>();
            topLevelActions = new List<Action>();
        }

        public void Save(string filepath)
        {
            //TODO figure out what exceptions need handling
            ModelDAO dao = new ModelDAO();
            foreach(Action action in actions)
            {
                dao.Actions.Add(action.CreateDTO());
            }
            foreach(Action action in topLevelActions)
            {
                dao.TopLevelActions.Add(action.Name);
            }
            foreach(Variable variable in variables)
            {
                dao.Variables.Add(variable.CreateDTO());
            }
            dao.Save(filepath);
        }

        public void Load(string filepath)
        {
            //TODO figure out what exceptions need to be handled

            ModelDAO dao = ModelDAO.Load(filepath);

            // TODO create variables from DAO
            foreach(VariableDTO varDTO in dao.Variables)
            {
                variables.Add(new Variable(this, varDTO));
            }
            // TODO create actions from DAO, using named variables (possible exception: name not found)
            foreach(ActionDTO actDTO in dao.Actions)
            {
                Action action = new Action(this, actDTO.Name, actDTO.Description, actDTO.IsPrimitive);
                foreach(StatementDTO stateDTO in actDTO.Conditions)
                {
                    //TODO exception if not found
                    Variable variable = variables.Find((Variable v) => { return v.Name == stateDTO.Variable; });
                    action.addCondition(variable, stateDTO.Value);
                }
                foreach (StatementDTO stateDTO in actDTO.Effects)
                {
                    //TODO exception if not found
                    Variable variable = variables.Find((Variable v) => { return v.Name == stateDTO.Variable; });
                    action.addEffect(variable, stateDTO.Value);
                }
            }
            // TODO set action children based on names in DTO (possible exception: name not found)
            foreach (ActionDTO actDTO in dao.Actions)
            {
                // TODO try to find child by name, exception if not found
                // TODO try to add child, exception on relevant error code
            }
                // TODO set top level actions (possible exception: name not found)
            }
    }
}
