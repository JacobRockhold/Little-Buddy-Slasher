using System;

namespace Little_Buddy_Slasher
{
    public class PlayerNameInput
    {
        public string PlayerName()
        {
            const int NAME_MINIMUM_LENGTH = 1;
            const int NAME_MAXIMUM_LENGTH = 12;
            bool validName = false;
            string nameInput = string.Empty;
            do
            {
                try
                {
                    Console.Write("Enter your name: ");
                    nameInput = Console.ReadLine();
                    string trimmedName = nameInput.Trim();
                    if (trimmedName.Length >= NAME_MINIMUM_LENGTH && 
                        trimmedName.Length <= NAME_MAXIMUM_LENGTH &&
                        nameInput.Length <= NAME_MAXIMUM_LENGTH &&
                        nameInput.Length >= NAME_MINIMUM_LENGTH)
                    {
                        Console.WriteLine($"Your name is: {nameInput}");
                        validName = true;
                    }
                    else
                    {
                        Console.WriteLine("The name you entered was too long or not long enough.\n" +
                            $"Names must be a maximum of {NAME_MAXIMUM_LENGTH} and minimum of {NAME_MINIMUM_LENGTH} character.\n" +
                            "Please try again.");
                        continue;
                    }
                    
                }
                catch (Exception e)
                {
                    StandardMessages.ErrorOutput(e.Message);
                    continue;
                }
            } while (validName == false);
            return nameInput;
        }        
    }
}
