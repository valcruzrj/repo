﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class ReservationValidator : AbstractValidator<ReservationDto>
    {
        public ReservationValidator()
        {
            RuleFor(x => x.CarId).NotEmpty().WithMessage("Informe o carro da reserva");
            RuleFor(x => x.Status).NotNull().WithMessage("Informe o status da reserva");
            RuleFor(x => x.Type).NotNull().WithMessage("Informe o tipo da reserva");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Informe a data e hora inicial da reserva");
        }
    }
}
