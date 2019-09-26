using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class AssociateValidator : AbstractValidator<AssociateDto>
    {
        public AssociateValidator()
        {
            RuleFor(x => x.Agreement).NotEmpty().WithMessage("Informe o convênio");
            RuleFor(x => x.Customer).NotEmpty().WithMessage("Informe o cliente");
            RuleFor(x => x.Quantity).NotEqual(0).WithMessage("Informe a quantidade de vagas");
        }
    }
}
