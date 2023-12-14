using IFSPReceita.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Domain.Entities
{
    public class Medico : BaseEntity<int>
    {
        public Medico()
        {

        }

        public Medico(int id, string? nome, string? especialidade, string? email, int crm, string? endereco, int numero, string? bairro, int telefone) : base(id)
        {
            Nome = nome;
            Especialidade = especialidade;
            Email = email;
            CRM = crm;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Telefone = telefone;
            Id = id;
        }
        public string? Nome { get; set; }
        public string? Especialidade { get; set; }
        public string? Email { get; set; }
        public int? CRM { get; set; }
        public string? Endereco { get; set; }
        public int? Numero { get; set; }
        public string? Bairro { get; set; }
        public int? Telefone { get; set; }
    }
}
