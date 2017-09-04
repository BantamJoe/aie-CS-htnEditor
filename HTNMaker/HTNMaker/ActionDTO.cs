using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    public class ActionDTO
    {
        public string Name;
        public string Description;
        public bool IsPrimitive;
        public List<StatementDTO> Conditions;
        public List<StatementDTO> Effects;
        public List<string> Children;

        public ActionDTO()
        {
            Conditions = new List<StatementDTO>();
            Effects = new List<StatementDTO>();
            Children = new List<string>();
        }
    }
}
