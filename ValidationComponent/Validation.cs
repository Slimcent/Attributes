using System;
using ValidationComponent.CustomAttributes;
using System.Reflection;
using System.Linq;
namespace ValidationComponent
{
    public static class Validation
    {

        public static bool PropertyValueIsValid(Type t, string enteredValue, string elementName, out string errorMessage)
        {
            PropertyInfo prop = t.GetProperty(elementName);

            Attribute[] attributes = prop.GetCustomAttributes().ToArray();

            errorMessage = "";

            foreach (Attribute attribute in attributes)
            {
                switch (attribute)
                {
                    case RequiredAttribute requiredAttribute:
                        if (!FieldRequiredIsValid(enteredValue))
                        {
                            errorMessage = requiredAttribute.ErrorMessage;
                            errorMessage = string.Format(errorMessage, prop.Name);

                            return false;
                        }
                        break;
                }
            }
            
            return true;
        }
        private static bool FieldRequiredIsValid(string enteredValue)
        {
            if (!string.IsNullOrEmpty(enteredValue))
                return true;

            return false;
        }
    }
}
