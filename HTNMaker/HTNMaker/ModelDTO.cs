using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    public class ModelDTO
    {
        List<ActionDTO> Actions;
        List<VariableDTO> Variables;
        List<string> TopLevelActions;

        public ModelDTO()
        {
            Actions = new List<ActionDTO>();
            Variables = new List<VariableDTO>();
            TopLevelActions = new List<string>();
        }
    }
}
