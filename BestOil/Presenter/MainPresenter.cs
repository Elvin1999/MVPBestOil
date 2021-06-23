using BestOil.Data;
using BestOil.Model;
using BestOil.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil.Presenter
{
    public class MainPresenter
    {
        private readonly PetrolContext _db;
        private IMainView _view;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.ComboboxIndexChanged += ComboboxIndexChange;
            _view.CheckedChangedLiter += LiterCheckedChanged;
            _view.CheckedChangedAzn += AznCheckedChanged;
            _view.CalculateButtonClicked += CalculateButtonClicked;

            _db = new PetrolContext();
            _db.Petrols.Add(new Petrol { Name = "AI95", Price = 1.4 });
            _db.Petrols.Add(new Petrol { Name = "AI92", Price = 1 });
            _db.Petrols.Add(new Petrol { Name = "Dizel", Price = 0.8 });
            _db.SaveChanges();
            var list = _db.Petrols.ToList();
            _view.Petrols = list;
        }
        
        public void ComboboxIndexChange(object sender,EventArgs e)
        {
            var item = (sender as ComboBox).SelectedItem;
            var petrol = item as Petrol;
            _view.PriceText = petrol.Price.ToString();
        }

        public void LiterCheckedChanged(object sender,EventArgs e)
        {
            var item = sender as RadioButton;
            if (item.Checked)
            {
                _view.LiterEnabled = true;
            }
            else
            {
                _view.LiterEnabled = false;
            }
        }
        
        public void AznCheckedChanged(object sender,EventArgs e)
        {
            var item = sender as RadioButton;
            if (item.Checked)
            {
                _view.PriceEnabled = true;
            }
            else
            {
                _view.PriceEnabled = false;
            }
        }
        public void CalculateButtonClicked(object sender,EventArgs e)
        {
            if (_view.LiterEnabled)
            {
                var money = double.Parse(_view.LiterText) * (double.Parse(_view.PriceText));
                _view.TotalText = money.ToString();
            }
            else
            {
                var money = double.Parse(_view.MoneyText) / (double.Parse(_view.PriceText));
                _view.LiterText = String.Empty;
                var moneyFull = (int)money;
                _view.LiterText = moneyFull.ToString();
                _view.TotalText = _view.MoneyText;
            }



        }

    }
}
