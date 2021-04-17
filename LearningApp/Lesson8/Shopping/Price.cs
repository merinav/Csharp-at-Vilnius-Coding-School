using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson8.Shopping
{
    class Price
    {
        int CurrentPrice;
        int CurrentBonusPrice;
        int FixedPrice;

        public Price(int currentPrice = 0, int currentBonusPrice = 0, int fixedPrice = 0) 
        {
            CurrentPrice = currentPrice;
            CurrentBonusPrice = currentBonusPrice;
            FixedPrice = fixedPrice;
        }

        void ApplyCurrentBonusPrice() 
        {
        
        }

        void IsBonusPriceApplicable()
        {

        }
    }
}
