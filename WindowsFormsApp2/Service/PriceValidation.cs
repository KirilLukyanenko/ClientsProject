using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2.Service
{
    public class PriceValidation
    {
        public bool IsValid { get; private set; }
        public string WarningMessage { get; private set; }

        public PriceValidation(string price, string discount)
        {
            bool isValidPrice = PriceStringValidation(price);
            bool isValidDiscount = DiscountValidation(discount);

            if (!isValidPrice || !isValidDiscount)
            {
                IsValid = false;
            }
            else
            {
                IsValid = true;
            }
        }

        private bool PriceStringValidation(string price)
        {
            if (String.IsNullOrEmpty(price))
            {
                WarningMessage += Resources.NullPriceWarning + Environment.NewLine;
                return false;
            }

            decimal convertedPart = 0;
            bool check = Decimal.TryParse(price, out convertedPart);

            if (!check)
            {
                WarningMessage += Resources.PriceWarning + Environment.NewLine;
            }

            return check;
        }

        private bool DiscountValidation(string discount)
        {
            if (String.IsNullOrEmpty(discount))
                return true;

            decimal convertedPart = 0;
            bool check = Decimal.TryParse(discount, out convertedPart);

            if (!check)
            {
                WarningMessage += Resources.DiscountWarning;
                return false;
            }

            if (convertedPart < 1 || convertedPart > 100)
            {
                WarningMessage += Resources.DiscountLengthWarning;
                return false;
            }

            return true; ;
        }
    }
}
