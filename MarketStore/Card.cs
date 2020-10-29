using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
  abstract  class Card
    {
        protected string owner;
        protected double turnoverForPreviousMonth;
        protected double discountRate;
        protected Card(string owner, double turnoverForPreviousMonth)
        {
            this.owner = owner;
            this.turnoverForPreviousMonth = turnoverForPreviousMonth;
            handleException();
        }
        private void handleException()
        {
            if (this.turnoverForPreviousMonth < 0)
                throw new Exception("Turnover can't be negative");
           
        }
        public abstract void CalculateDiscountRate();
        private string formatString(double value) => 
            string.Format("{0:0.00}", Math.Round(value, 2)).Replace(',','.');
            //Math.Round(value,2).ToString();
        public void RequiredDataOutput(double valueOfPurchase)
        {
            double discount =((double)(this.discountRate * 0.01) )* valueOfPurchase;
            Console.WriteLine($"Purchase value: ${formatString(valueOfPurchase)}");
            Console.WriteLine($"Discount rate: {formatString(this.discountRate)}%");
            Console.WriteLine($"Discount: ${formatString(discount)}");
            Console.WriteLine($"Total: ${formatString(valueOfPurchase-discount)}");
        }
       
        
        
    }
}
