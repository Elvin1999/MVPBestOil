using BestOil.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil.View
{
    public partial class MainView : Form,IMainView
    {
        public EventHandler<EventArgs> ComboboxIndexChanged { get; set; }
        public EventHandler<EventArgs> CheckedChangedLiter { get; set; }
        public EventHandler<EventArgs> CheckedChangedAzn { get; set; }
        public EventHandler<EventArgs> CalculateButtonClicked { get; set ; }
        public List<Petrol> Petrols { set {
                comboBox1.DataSource = null;
                comboBox1.DataSource = value;  
            } }
        public string PriceText { get => priceLbl.Text; set => priceLbl.Text=value; }
        public bool IsLiter { get => literRadiobtn.Checked; set => literRadiobtn.Checked=value; }
        public string LiterText { get => literMaskettxtb.Text; set => literMaskettxtb.Text=value; }
        public string MoneyText { get => aznMaskedTxtb.Text; set => aznMaskedTxtb.Text=value; }
        public string TotalText { get => totalLbl.Text; set => totalLbl.Text=value; }
        public bool LiterEnabled { get => literMaskettxtb.Enabled; set => literMaskettxtb.Enabled=value; }
        public bool PriceEnabled { get => aznMaskedTxtb.Enabled; set => aznMaskedTxtb.Enabled=value; }

        public MainView()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxIndexChanged.Invoke(sender, e);
        }

        private void literRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedLiter.Invoke(sender, e);
        }

        private void aznRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedAzn.Invoke(sender, e);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            CalculateButtonClicked.Invoke(sender, e);
        }
    }
}
