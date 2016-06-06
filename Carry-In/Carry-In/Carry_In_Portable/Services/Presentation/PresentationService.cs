using Carry_In.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Carry_In.Services.Presentation
{
    public interface PresentationService
    {
        ObservableCollection<Food> Food { get; }
        ObservableCollection<Location> Locations { get; }
        ObservableCollection<Restaurant> Restaurants { get; }
    }
}
