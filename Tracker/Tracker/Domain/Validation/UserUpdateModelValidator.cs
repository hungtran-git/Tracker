using System;
using FluentValidation;
using Tracker.Domain.Models;

namespace Tracker.Domain.Validation
{
    public partial class UserUpdateModelValidator
        : AbstractValidator<UserUpdateModel>
    {
        public UserUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.EmailAddress).NotEmpty();
            RuleFor(p => p.EmailAddress).MaximumLength(256);
            RuleFor(p => p.DisplayName).NotEmpty();
            RuleFor(p => p.DisplayName).MaximumLength(256);
            RuleFor(p => p.CreatedBy).MaximumLength(100);
            RuleFor(p => p.UpdatedBy).MaximumLength(100);
            #endregion
        }

    }
}
