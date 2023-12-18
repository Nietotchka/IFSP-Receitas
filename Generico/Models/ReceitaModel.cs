using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceitas.App.Models
{
    internal class ReceitaModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Validade { get; set; }
        public string Medico { get; set; }
        public string Paciente { get; set; }
        public string Medicamento { get; set; }

    }
}
