using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    public class Statement
    {
        // TODO write getter/setters, decide if read only, etc
        public Variable Variable { get; set; }
        public string VariableName { get { return Variable.Name; } }
        public bool Value { get; set; }

        public Statement(Variable variable, bool value)
        {
            //TODO maybe use private members instead?
            this.Variable = variable;
            this.Value = value;
        }

        public StatementDTO CreateDTO()
        {
            StatementDTO dto = new StatementDTO();
            dto.Value = Value;
            dto.Variable = Variable.Name;
            return dto;
        }
    }
}
