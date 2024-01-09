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
        RuleForEach(x => x.Cars).SetValidator(new CarValidator());
    }
}