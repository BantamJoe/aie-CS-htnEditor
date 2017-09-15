using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HTNMaker
{
    public class Model
    {
        private List<Action> actions;
        private List<Variable> variables;
        private List<Action> topLevelActions;
        
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
        public List<Action> TopLevelActions
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

        public void Save(Stream stream)
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
            dao.Save(stream);
        }

        public void Load(Stream stream)
        {
            ModelDAO dao = ModelDAO.Load(stream);

            List<Action> loadedActions = new List<Action>();
            List<Variable> loadedVariables = new List<Variable>();
            List<Action> loadedTopActions = new List<Action>();


            // create variables from DAO
            foreach(VariableDTO varDTO in dao.Variables)
            {
                loadedVariables.Add(new Variable(varDTO));
            }
            // create actions from DAO, using named variables 
            foreach(ActionDTO actDTO in dao.Actions)
            {
                Action action = new Action(actDTO.Name, actDTO.Description, actDTO.IsPrimitive);
                // Add conditions, effects
                foreach (StatementDTO stateDTO in actDTO.Conditions)
                {
                    Variable variable = loadedVariables.Find((Variable v) => { return v.Name == stateDTO.Variable; });
                    if (variable != null)
                    {
                        action.addCondition(variable, stateDTO.Value);
                    } else
                    {
                        throw new InvalidDataException("Variable \"" + stateDTO.Variable + "\" used as condition of \"" + action.Name + "\" could not be found");
                    }
                }
                foreach (StatementDTO stateDTO in actDTO.Effects)
                {
                    Variable variable = loadedVariables.Find((Variable v) => { return v.Name == stateDTO.Variable; });
                    if (variable != null)
                    {
                        action.addEffect(variable, stateDTO.Value);
                    } else
                    {
                        throw new InvalidDataException("Variable \"" + stateDTO.Variable + "\" used as effect of \"" + action.Name + "\" could not be found");
                    }
                }
                loadedActions.Add(action);
            }
            // set action children based on names in DTO 
            foreach (ActionDTO actDTO in dao.Actions)
            {
                Action action = loadedActions.Find(a => { return a.Name == actDTO.Name; });
                foreach (string childName in actDTO.Children)
                {
                    // try to find child by name, exception if not found
                    Action child = loadedActions.Find(a => { return a.Name == childName; });
                    if(child != null)
                    {
                        // try to add child, exception on relevant error code
                        int resultCode = action.addChild(child);
                        switch (resultCode)
                        {
                            case 0:
                                break;
                            case 1:
                                throw new InvalidDataException("Child action \"" + childName + "\" cannot be added to  \"" + action.Name + "\": \"" + action.Name + "\" is primitive");
                                break;
                            case 2:
                                // Action added twice, no need to throw exception
                                break;
                            case 3:
                                throw new InvalidDataException("Child action \"" + childName + "\" cannot be added to  \"" + action.Name + "\": Cycle detected");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        throw new InvalidDataException("Child action \"" + childName + "\" of action \"" + action.Name + "\" could not be found");
                    }
                }
                
            }
                // set top level actions
            foreach(string actionName in dao.TopLevelActions)
            {
                Action action = loadedActions.Find(a => { return a.Name == actionName; });
                if(action != null)
                {
                    loadedTopActions.Add(action);
                } else
                {
                    throw new InvalidDataException("Root level action \""+actionName+"\" could not be found");
                }
            }
            actions = loadedActions;
            variables = loadedVariables;
            topLevelActions = loadedTopActions;
        }
    }
}
