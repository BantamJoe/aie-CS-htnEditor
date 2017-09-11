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
            //TODO check filepath has .xml extension
            XmlSerializer serializer = new XmlSerializer(typeof(ModelDAO));
            serializer.Serialize(stream, this);
        }

        public static ModelDAO Load(string filepath)
        {
            // TODO check filepath extension
            XmlSerializer serializer = new XmlSerializer(typeof(ModelDAO));
            ModelDAO dao;
            using (StreamReader sr = new StreamReader(filepath))
            {
                dao = serializer.Deserialize(sr) as ModelDAO;
            }
            // TODO check no two variable share a name, throw exception if so
            // TODO check no actions share a name, throw exception if so
            // TODO remove duplicates in top level actions
            return dao;
        }
    }
}
