using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class CarValidator : AbstractValidator<CarDto>
    {
        public CarValidator()
        {
            RuleFor(x => x.Color).NotEmpty().WithMessage("Informe a cor");
            RuleFor(x => x.Year).NotEmpty().WithMessage("Informe o ano de fabricação");
            RuleFor(x => x.Model).NotEmpty().WithMessage("Informe o modelo");
            RuleFor(x => x.LicensePlate).NotEmpty().WithMessage("Informe a placa");
        }
    }
}
