using FluentValidation;
using IFSPReceita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Service.Validators
{
    public class ReceitaValidator : AbstractValidator<Receita>
    {
        public ReceitaValidator()
        {
            RuleFor(c => c.Data)
                    .NotEmpty().WithMessage("Por favor informe a data.")
                    .NotNull().WithMessage("Por favor informe a data.");
            RuleFor(c => c.Validade)
                   .NotEmpty().WithMessage("Por favor informe a validade.")
                   .NotNull().WithMessage("Por favor informe a validade.");

        }

    }
}
