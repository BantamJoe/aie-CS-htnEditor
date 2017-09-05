using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    public class Variable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                // TODO somewhere, check name is unique
                name = Name;
            }
        }

        public string Description { get; set; }

        public Variable(string name, string description = "")
        {
            this.name = name;
            Description = description;
        }

        public Variable(VariableDTO dto)
        {
            name = dto.Name;
            Description = dto.Description;
        }

        public VariableDTO CreateDTO()
        {
            VariableDTO dto = new VariableDTO();
            dto.Name = name;
            dto.Description = Description;
            return dto;
        }
    }
}
