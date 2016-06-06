using System;
using System.Collections.Generic;


namespace Carry_In.Services.Data.Restaurant
{
    public interface RestaurantDataService
    {
        IEnumerable<Model.Restaurant> Restaurants();
        IEnumerable<Model.Restaurant> Restaurants(long id);
    }
}
