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

        public void Save(string filepath)
        {
            //TODO check filepath has .xml extension
            XmlSerializer serializer = new XmlSerializer(typeof(ModelDAO));
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                serializer.Serialize(sw, this);
            }
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
            return dao;
        }
    }
}
