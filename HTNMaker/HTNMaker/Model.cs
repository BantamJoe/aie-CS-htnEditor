using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    class Model
    {
        private List<Action> actions;
        private List<Variable> variables;
        private List<Action> topLevelActions;

        //TODO fields

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
            // TODO create actions from DAO, using named variables (possible exception: name not found)
            // TODO set action children based on names in DTO (possible exception: name not found)
            // TODO set top level actions (possible exception: name not found)
        }
    }
}
