using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTNMaker
{
    public class Variable
    {
        private Model model;
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

        public Variable(Model model, string name, string description = "")
        {
            this.model = model;
            this.name = name;
            Description = description;
        }

        public Variable(Model model, VariableDTO dto)
        {
            this.model = model;
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
