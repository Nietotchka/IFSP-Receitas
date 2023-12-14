﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceitas.App.Models
{
    internal class PacienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int Telefone { get; set; }
        public string Convenio { get; set; }
        public int NumeroConvenio { get; set; }
        public virtual int CPF { get; set; }

    }
}
