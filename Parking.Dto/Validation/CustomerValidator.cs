using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200).WithMessage("Informe um nome ou verifique o tamanho máximo do campo Descrição");
            RuleFor(x => x.Document).NotEmpty().WithMessage("Informe um documento válido");
            RuleFor(x => x.Type).NotEmpty().WithMessage("Informe um tipo de documento");
        }
    }
}
