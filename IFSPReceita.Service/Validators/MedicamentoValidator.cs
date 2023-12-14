using FluentValidation;
using IFSPReceita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Service.Validators
{
    public class MedicamentoValidator : AbstractValidator<Medicamento>
    {
        public MedicamentoValidator()
        {
            RuleFor(c => c.Nome)
                    .NotEmpty().WithMessage("Por favor informe o nome.")
                    .NotNull().WithMessage("Por favor informe o nome.");

        }
    }
}
