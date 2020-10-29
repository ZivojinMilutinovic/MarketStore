using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class BronzeCard : Card
    {
        public BronzeCard(string owner,double turnoverForPreviousMonth):base(owner,turnoverForPreviousMonth)
        {
            
            CalculateDiscountRate();
        }

        public override void CalculateDiscountRate()
        {
            if (this.turnoverForPreviousMonth < 100)
                this.discountRate = 0;
            else if (this.turnoverForPreviousMonth >= 100 && this.turnoverForPreviousMonth <= 300)
                this.discountRate = 1;
            else if (this.turnoverForPreviousMonth > 300)
                this.discountRate = 2.5;
             
        }
    }
}
