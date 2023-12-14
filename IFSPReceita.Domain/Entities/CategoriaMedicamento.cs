using IFSPReceita.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Domain.Entities
{
    public class CategoriaMedicamento : BaseEntity<int>
    {
        public CategoriaMedicamento()
        {

        }

        public CategoriaMedicamento(int id, string? categoria) : base(id)
        {
            Categoria = categoria;
            Id = id;
        }
        public string? Categoria { get; set; }


    }
}
