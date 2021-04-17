using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson8.Shopping
{
    class Good
    {
        
        public int GoodsAvailableInWarehouse;
        public bool GoodsReadyToShip;

        public Good(int goodsAvailableInWarehouse, bool goodsReadyToShip) 
        {
            GoodsAvailableInWarehouse = goodsAvailableInWarehouse;
            GoodsReadyToShip = goodsReadyToShip;
        }

        public void CheckIfGoodsReadyToShip() 
        {        
        }
        private void CollectGoods()
        {
        }
        private void ShipGoods()
        {
        }


    }
}
