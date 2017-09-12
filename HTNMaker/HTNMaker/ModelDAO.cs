using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace HTNMaker
{
    public class ModelDAO
    {
        public List<ActionDTO> Actions;
        public List<VariableDTO> Variables;
        public List<string> TopLevelActions;

        public ModelDAO()
        {
            Actions = new List<ActionDTO>();
            Variables = new List<VariableDTO>();
            TopLevelActions = new List<string>();
        }

        public void Save(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ModelDAO));
            serializer.Serialize(stream, this);
        }

        public static ModelDAO Load(Stream stream)
        {
            // TODO check filepath extension
            XmlSerializer serializer = new XmlSerializer(typeof(ModelDAO));
            ModelDAO dao;
            dao = serializer.Deserialize(stream) as ModelDAO;
            // check no two variable share a name, throw exception if so
            HashSet<String> hs = new HashSet<string>();
            bool varUniqueNames = dao.Variables.All(x => hs.Add(x.Name));
            if (!varUniqueNames)
            {
                throw new InvalidDataException("Variable name collision");
            }
            hs.Clear();
            // check no actions share a name, throw exception if so
            bool actionUniqueNames = dao.Actions.All(x => hs.Add(x.Name));
            if(!actionUniqueNames)
            {
                throw new InvalidDataException("Action name collision");
            }
            return dao;
        }
    }
}
