using FluentValidation;

namespace Little_Buddy_Slasher
{
    public class PlayerNameValidator : AbstractValidator<PlayerModel>
    {
        public PlayerNameValidator()
        {
            const int MINIMUM_LENGTH = 1;
            const int MAXIMUM_LENGTH = 25;
            RuleFor(playerInput => playerInput.PlayerName)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} is invalid")
                .NotEmpty().WithMessage("{PropertyName} cannot be empty")
                .Length(MINIMUM_LENGTH, MAXIMUM_LENGTH).WithMessage("" +
                "{PropertyName} must be greater than " + MINIMUM_LENGTH +
                " and less than " + MAXIMUM_LENGTH + " characters");
        }
    }
}
