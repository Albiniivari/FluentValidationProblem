using BlazorApp1.Components.Model;

namespace BlazorApp1.Components.Validators;

using System;
using FluentValidation;



public class CarValidator : AbstractValidator<Car>
{
    public CarValidator()
    {
        RuleFor(car => car.Model).NotEmpty();
        RuleFor(car => car.LicensePlate).NotEmpty();
        RuleFor(car => car.Name).NotEmpty();
    }
}