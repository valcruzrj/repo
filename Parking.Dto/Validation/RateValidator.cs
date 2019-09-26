using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class RateValidator : AbstractValidator<RateDto>
    {
        public RateValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200).WithMessage("Informe um nome ou verifique o tamanho máximo do campo Descrição");
            RuleFor(x => x.DailyAmount).NotEqual(0).WithMessage("Informe o valor da diária");
            RuleFor(x => x.OvernightAmount).NotEqual(0).WithMessage("Informe o valor da pernoite");
            RuleFor(x => x.HourAmount).NotEqual(0).WithMessage("Informe o valor por hora");
        }
    }
}
