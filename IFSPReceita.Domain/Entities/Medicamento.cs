using IFSPReceita.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Domain.Entities
{
    public class Medicamento : BaseEntity<int>
    {
        public Medicamento()
        {

        }

        public Medicamento(int id, string? nome, string? categoria) : base(id)
        {
            Nome = nome;
            Id = id;
            Categoria = categoria;  
        }
        public string? Nome { get; set; }

        public string? Categoria { get; set; }


    }
}
