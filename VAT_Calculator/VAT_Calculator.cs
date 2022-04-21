using System;
namespace Ex_2
{
    public class VAT_Calculator
    {
        public double _vatRate;
        public double _amountWithOrWithoutTax;

        public VAT_Calculator()
        {
            _vatRate = 20;
        }

        public double SetVATValue(double newVatRate)
        {
            _vatRate = newVatRate;
            return newVatRate;
        }

        public double FindVATFromPrice(double price)
        {
            double vatFromPrice = price * _vatRate / 100;
            return vatFromPrice;
        }

        public double FindPrice(bool isWithTax, double amount)
        {
            if (isWithTax == true)
            {
                _amountWithOrWithoutTax = amount - (amount * _vatRate * 0.8335 / 100);
            }
            else if (isWithTax == false)
            {
                _amountWithOrWithoutTax = amount + (amount * _vatRate / 100);
            }

            return _amountWithOrWithoutTax;
        }

        public double FindPriceBasedOnTax(double amount)
        {
            double priceFromVAT = 100 / _vatRate * amount;
            return priceFromVAT;
        }

        public bool IsVAT20()
        {
            if (_vatRate == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
