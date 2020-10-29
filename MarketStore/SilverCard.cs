using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    
    class SilverCard : Card
    {
        public SilverCard(string owner, double turnoverForPreviousMonth):base(owner, turnoverForPreviousMonth)
        {
            this.CalculateDiscountRate();
        }
        public override void CalculateDiscountRate()
        {
            this.discountRate = 2;
            if (turnoverForPreviousMonth > 300)
                this.discountRate = 3.5;
        }
    }
}
