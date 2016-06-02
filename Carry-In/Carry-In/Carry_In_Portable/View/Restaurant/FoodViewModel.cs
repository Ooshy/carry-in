using Carry_In.Models;
using System.Collections.Generic;

namespace Carry_In.Pages.Restaurant.FoodTabs
{
    public class RestaurantViewModel
    {
        public Models.Restaurant RestaurantModel { get; set; }
        public RestaurantViewModel(Models.Restaurant restaurant)
        {
            RestaurantModel = restaurant;
        }


        public IList<FoodItem> CurrentFoods
        {
            get
            {
                return Foods(CurrentFoodType);
            }
        }

        public FoodType CurrentFoodType { get; set; }

        private IDictionary<FoodType, IList<FoodItem>> foods_ = new Dictionary<FoodType, IList<FoodItem>>();
        public IList<FoodItem> Foods(FoodType foodType)
        {
            if (foods_.ContainsKey(foodType))
                return foods_[foodType];
            else
            {
                return PopulateFoods(foodType);
            }
        }

        private IList<FoodItem> PopulateFoods(FoodType foodType)
        {
            List<FoodItem> foods = new List<FoodItem>();
            //TODO Find Foods within the Restaurant Model
            switch (foodType)
            {
                case FoodType.Appetizers:
                    foods.AddRange(new List<FoodItem>()
                    {
                        new FoodItem()
                        {
                            Description="A fried onion",
                            Id=0,
                            Ingredients="Onion",
                            Name="Bloomin' Onion"
                        }
                    });
                    break;
                case FoodType.Beverages:
                    foods.AddRange(new List<FoodItem>()
                    {
                        new FoodItem()
                        {
                            Description="A cold, refreshing alcholic beverage.",
                            Id=0,
                            Ingredients="Barley",
                            Name="Edward's Ale"
                        }
                    });
                    break;
                case FoodType.Desserts:
                    foods.AddRange(new List<FoodItem>()
                    {
                        new FoodItem()
                        {
                            Description="Yummy icecream",
                            Id=0,
                            Ingredients="Milk, Cream",
                            Name="Bob's Ice Cream"
                        }
                    });
                    break;
                case FoodType.Entrees:
                    foods.AddRange(new List<FoodItem>()
                    {
                        new FoodItem()
                        {
                            Description="Pork fried rice",
                            Id=0,
                            Ingredients="Pork, Rice",
                            Name="A Chinese Dish"
                        }
                    });
                    break;
            }
            return foods;
        }
    }

}