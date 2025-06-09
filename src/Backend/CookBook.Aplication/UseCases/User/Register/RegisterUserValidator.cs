﻿using CookBook.Communication.Requests;
using CookBook.Exceptions;
using FluentValidation;

namespace CookBook.Aplication.UseCases.User.Register
{
    internal class RegisterUserValidator : AbstractValidator<RequestRegisterUserJson>
    {
        public RegisterUserValidator()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMessagesException.NAME_EMPTY);
            RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessagesException.EMAIL_EMPTY);
            RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMessagesException.EMAIL_INVALID);
            RuleFor(user => user.Password).NotEmpty().MinimumLength(6).WithMessage(ResourceMessagesException.PASSWORD_EMPTY);
        }
    }
}
