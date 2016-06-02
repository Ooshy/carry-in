using Microsoft.Azure.Mobile.Server;

namespace Carry_InService.DataObjects
{
    public class FoodItem : EntityData
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Ingredients { get; set; }

        public string IconUri { get; set; }

        public string IconCacheUri { get; set; }

    }
}