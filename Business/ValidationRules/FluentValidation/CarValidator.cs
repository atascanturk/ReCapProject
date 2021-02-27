using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(3);
            RuleFor(C => C.ModelYear).GreaterThan(2015);
            RuleFor(C => C.DailyPrice).GreaterThan(0);
        }
    }
}
