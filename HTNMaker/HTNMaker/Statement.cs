using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    public class Statement
    {
        public Variable Variable { get; set; }
        public string VariableName { get { return Variable.Name; } }
        public bool Value { get; set; }

        public Statement(Variable variable, bool value)
        {
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
