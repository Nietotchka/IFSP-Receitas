using FluentValidation;
using IFSPReceita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPReceita.Service.Validators
{
    public class MedicoValidator : AbstractValidator<Medico>
    {
        public MedicoValidator()
        {
            RuleFor(c => c.Nome)
                    .NotEmpty().WithMessage("Por favor informe o nome.")
                    .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Especialidade)
                   .NotEmpty().WithMessage("Por favor informe a especialidade.")
                   .NotNull().WithMessage("Por favor informe a especialidade.");
            RuleFor(c => c.Email)
                   .NotEmpty().WithMessage("Por favor informe o email.")
                   .NotNull().WithMessage("Por favor informe o email.");
            RuleFor(c => c.CRM)
                   .NotEmpty().WithMessage("Por favor informe o crm.")
                   .NotNull().WithMessage("Por favor informe o crm.");
            RuleFor(c => c.Endereco)
                   .NotEmpty().WithMessage("Por favor informe o endereço.")
                   .NotNull().WithMessage("Por favor informe o endereço.");
            RuleFor(c => c.Numero)
                   .NotEmpty().WithMessage("Por favor informe o numero.")
                   .NotNull().WithMessage("Por favor informe o numero.");
            RuleFor(c => c.Bairro)
                   .NotEmpty().WithMessage("Por favor informe o bairro.")
                   .NotNull().WithMessage("Por favor informe o bairro.");
            RuleFor(c => c.Telefone)
                   .NotEmpty().WithMessage("Por favor informe o telefone.")
                   .NotNull().WithMessage("Por favor informe o telefone.");

        }

    }
 }
    

