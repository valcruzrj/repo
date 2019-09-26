using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class AgreementValidator : AbstractValidator<AgreementDto>
    {
        public AgreementValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200).WithMessage("Informe um nome ou verifique o " +
                                                                       "tamanho máximo do campo Descrição");
            RuleFor(x => x.DiscountAmount).NotEqual(0).When(x => x.DiscountPercentual == 0).WithMessage("Informe um valor de desconto ou percentual");
            RuleFor(x => x.DiscountPercentual).NotEqual(0).When(x => x.DiscountAmount == 0).WithMessage("Informe um valor de desconto ou percentual");
        }
    }
}
