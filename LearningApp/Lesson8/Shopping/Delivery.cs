using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson8.Shopping
{
    class Delivery
    {
     
        string WarehouseLocation;
        bool IsDeliveryPaidFor;
        string DeliveryTo;

        public Delivery(string warehouseLocation, bool isDeliveryPaidFor = false, string deliveryTo = "Vilnius") 
        {
            WarehouseLocation = warehouseLocation;
            IsDeliveryPaidFor = isDeliveryPaidFor;
            DeliveryTo = deliveryTo;

        }

        void ChooseDeliveryType()        
        {
        
        }
        void CheckIfDeliveryPaid()
        {

        }
    }
}
