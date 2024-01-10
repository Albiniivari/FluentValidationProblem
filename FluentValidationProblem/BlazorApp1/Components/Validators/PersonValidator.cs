using BlazorApp1.Components.Model;

namespace BlazorApp1.Components.Validators;

using System;
using FluentValidation;

public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(person => person.Name)
            .NotEmpty()
            .WithMessage("Must have a name");
        // Lägenheterna ska använda en egen Validator.
        RuleSet("Cars", () =>
        {
            RuleForEach(x => x.Cars).SetValidator(new CarValidator());
            RuleFor(x => x.Cars).NotEmpty().WithMessage("At least 1 car has to be selected.");
        });
    }
}