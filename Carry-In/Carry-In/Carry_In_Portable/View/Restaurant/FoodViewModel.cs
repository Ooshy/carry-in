using Carry_In.Model;
using System.Collections.Generic;

namespace Carry_In.View.Restaurant.FoodTabs
{
    public class RestaurantViewModel
    {
        public Model.Restaurant RestaurantModel { get; set; }
        public RestaurantViewModel(Model.Restaurant restaurant)
        {
            RestaurantModel = restaurant;
        }


        public IList<Food> CurrentFoods
        {
            get
            {
                return Foods(CurrentFoodType);
            }
        }

        public FoodType CurrentFoodType { get; set; }

        private IDictionary<FoodType, IList<Food>> foods_ = new Dictionary<FoodType, IList<Food>>();
        public IList<Food> Foods(FoodType foodType)
        {
            if (foods_.ContainsKey(foodType))
                return foods_[foodType];
            else
            {
                return PopulateFoods(foodType);
            }
        }

        private IList<Food> PopulateFoods(FoodType foodType)
        {
            List<Food> foods = new List<Food>();
            //TODO Find Foods within the Restaurant Model
            switch (foodType)
            {
                case FoodType.Appetizers:
                    foods.AddRange(new List<Food>()
                    {
                        new Food()
                        {
                            Description="A fried onion",
                            Id=0,
                            Ingredients="Onion",
                            Name="Bloomin' Onion"
                        }
                    });
                    break;
                case FoodType.Beverages:
                    foods.AddRange(new List<Food>()
                    {
                        new Food()
                        {
                            Description="A cold, refreshing alcholic beverage.",
                            Id=0,
                            Ingredients="Barley",
                            Name="Edward's Ale"
                        }
                    });
                    break;
                case FoodType.Desserts:
                    foods.AddRange(new List<Food>()
                    {
                        new Food()
                        {
                            Description="Yummy icecream",
                            Id=0,
                            Ingredients="Milk, Cream",
                            Name="Bob's Ice Cream"
                        }
                    });
                    break;
                case FoodType.Entrees:
                    foods.AddRange(new List<Food>()
                    {
                        new Food()
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