using System;
using ValidationComponent;

namespace AttributesApp
{
    public static class ModelInput
    {
        public static bool GetInput(Type t, string promptText, string fieldName, out string fieldValue)
        {
            do
            {
                Console.WriteLine(promptText);
                string enteredValue = Console.ReadLine();

                if (!Validation.PropertyValueIsValid(t, enteredValue, fieldName, out string errorMessage))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(errorMessage);
                    Console.WriteLine();
                    Console.ResetColor();
                }
                else
                {
                    fieldValue = enteredValue;
                    break;
                }
            }
            while (true);

            return true;
        }
    }
}
