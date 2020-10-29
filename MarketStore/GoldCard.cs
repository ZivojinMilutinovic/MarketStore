using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class GoldCard : Card
    {
        public GoldCard(string owner, double turnoverForPreviousMonth) : base(owner, turnoverForPreviousMonth)
        {
            CalculateDiscountRate();
        }
        public override void CalculateDiscountRate()
        {
            this.discountRate = 2;
            int numberOfProcent = (int)(this.turnoverForPreviousMonth / 10);
            if (numberOfProcent > 8) 
                this.discountRate = 10;
            else
            {
                this.discountRate += numberOfProcent;
            }
        }
    }
}
