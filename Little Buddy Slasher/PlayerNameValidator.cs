using System;
using FluentValidation;
using FluentValidation.Results;

namespace Little_Buddy_Slasher
{
    public class PlayerNameValidator : AbstractValidator<PlayerModel>
    {
        public PlayerNameValidator()
        {
            const int MINIMUM_LENGTH = 1;
            const int MAXIMUM_LENGTH = 25;
            RuleFor(playerInput => playerInput.ReturnPlayerName())
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} is invalid")
                .NotEmpty().WithMessage("{PropertyName} cannot be empty")
                .Length(MINIMUM_LENGTH, MAXIMUM_LENGTH).WithMessage("" +
                "{PropertyName} must be greater than " + MINIMUM_LENGTH +
                " and less than " + MAXIMUM_LENGTH + " characters");
        }


        //public static string PlayerName()
        //{
        //    const int NAME_MINIMUM_LENGTH = 1;
        //    const int NAME_MAXIMUM_LENGTH = 12;
        //    bool validName = false;
        //    string nameInput = string.Empty;
        //    do
        //    {
        //        try
        //        {
        //            Console.Write("Enter your name: ");
        //            nameInput = Console.ReadLine();
        //            string trimmedName = nameInput.Trim();
        //            if (trimmedName.Length >= NAME_MINIMUM_LENGTH && 
        //                trimmedName.Length <= NAME_MAXIMUM_LENGTH &&
        //                nameInput.Length <= NAME_MAXIMUM_LENGTH &&
        //                nameInput.Length >= NAME_MINIMUM_LENGTH)
        //            {
        //                Console.WriteLine($"Your have entered: {nameInput} is this correct? [y/n]");
        //                string confirmation = Console.ReadLine();

        //                if (confirmation == "y")
        //                {
        //                    validName = true;
        //                }
        //                else
        //                {
        //                    Console.Clear();
        //                    continue;
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("The name you entered was too long or not long enough.\n" +
        //                    $"Names must be a maximum of {NAME_MAXIMUM_LENGTH} and minimum of {NAME_MINIMUM_LENGTH} character.\n" +
        //                    "Please try again.");
        //                continue;
        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            StandardMessages.ErrorOutput(e.Message);
        //            continue;
        //        }
        //    } while (validName == false);
        //    return nameInput;
        //}
    }
}
