using IFSPReceita.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Domain.Entities
{
    public class Paciente : BaseEntity<int>
    {
        public Paciente()
        {

        }

        public Paciente(int id, string? nome, string? email, string? endereco, int numero, string? bairro, int telefone, string? convenio, int numeroConvenio, UInt64 cpf) : base(id)
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Telefone = telefone;
            Convenio = convenio;
            NumeroConvenio = numeroConvenio;
            CPF = cpf;
            Id = id;
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int Telefone { get; set; }
        public string Convenio { get; set; }
        public int NumeroConvenio { get; set; }
        public virtual UInt64 CPF { get; set; }
    }
}
