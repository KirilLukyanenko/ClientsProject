using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Enums;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2.Service
{
    public class ProductValidation
    {
        public bool IsValid { get; private set; }
        public string WarningMessage { get; private set; }

        public ProductValidation(string code, string name, string weight)
        {
            bool isValidCode = CodeValidation(code);
            bool isValidName = NameValidation(name);
            bool isValidWeight = WeightValidation(weight);

            if (!isValidCode || !isValidName || !isValidWeight)
            {
                IsValid = false;
            }
            else
            {
                IsValid = true;
            }
        }

        private bool CodeValidation(string code)
        {
            if (code.Length != 7)
            {
                WarningMessage += Resources.LengthCodeWarning + Environment.NewLine;
                return false;
            }

            string part1 = code.Substring(0, 3);
            string part2 = code.Substring(4, 3);

            int convertedPart = 0;
            bool check1 = Int32.TryParse(part1, out convertedPart);
            bool check2 = Int32.TryParse(part2, out convertedPart);

            if (check1 && check2 && code[3] == '-')
                return true;

            WarningMessage += Resources.CodeWarning + Environment.NewLine;

            return false;
        }

        private bool NameValidation(string name)
        {
            if (String.IsNullOrWhiteSpace(name) || name.Length > 255)
            {
                WarningMessage += Resources.NameWarning + Environment.NewLine;
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool WeightValidation(string weight)
        {
            if (String.IsNullOrEmpty(weight))
                return true;

            decimal convertedPart = 0;
            bool check = Decimal.TryParse(weight, out convertedPart);

            if (!check)
            {
                WarningMessage += Resources.WeightWarning;
            }

            return check;
        }
    }
}
