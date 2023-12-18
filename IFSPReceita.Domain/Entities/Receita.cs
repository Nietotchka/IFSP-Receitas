using IFSPReceita.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Domain.Entities
{
    public class Receita : BaseEntity<int>
    {
        public Receita()
        {
        }

        public Receita(int id, DateTime data, DateTime validade) : base(id)
        {
            Id = id;
            Data = data;
            Validade = validade;
        }


        public DateTime Data { get; set; }
        public DateTime Validade { get; set; }
        public Medico? Medico { get; set; }
        public Paciente? Paciente { get; set; }
        public Medicamento? Medicamento { get; set; }

    }
}
