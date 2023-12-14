using FluentValidation;
using IFSPReceita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Service.Validators
{
    public class CategoriaMedicamentoValidator : AbstractValidator<CategoriaMedicamento>
    {
        public CategoriaMedicamentoValidator()
        {
            RuleFor(c => c.Categoria)
                    .NotEmpty().WithMessage("Por favor informe a categoria.")
                    .NotNull().WithMessage("Por favor informe a categoria.");
           
        }
    }
}
