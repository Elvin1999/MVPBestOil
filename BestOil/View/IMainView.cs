using BestOil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil.View
{
   public interface IMainView
    {
        EventHandler<EventArgs> ComboboxIndexChanged { get; set; }
        EventHandler<EventArgs> CheckedChangedLiter { get; set; }
        EventHandler<EventArgs> CheckedChangedAzn { get; set; }
        EventHandler<EventArgs> CalculateButtonClicked { get; set; }
        List<Petrol> Petrols { set; }
        string PriceText { get; set; }
        bool IsLiter { get; set; }
        string LiterText { get; set; }
        string MoneyText { get; set; }
        string TotalText { get; set; }
        bool LiterEnabled { get; set; }
        bool PriceEnabled { get; set; }

    }
}
