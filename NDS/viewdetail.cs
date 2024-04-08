using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NDS
{
    public partial class viewdetail : Form
    {
        public viewdetail(Order item)
        {
            InitializeComponent();
            DisplayItemDetails(item);
        }

        private void DisplayItemDetails(Order item)
        {

            this.textBoxFormID.Text = item.FormID;
            this.dateTimePickerDate.Value = item.Date;
            this.textBoxCustomerID.Text = item.CustomerID;
            this.textBoxCustomerName.Text = item.CustomerName;
            this.textBoxAddress.Text = item.Address;
            this.textBoxNewspaperID.Text = item.NewspaperID;
            this.textBoxNewspaperName.Text = item.NewspaperName;
            this.textBoxPeriodicalPublication.Text = item.PeriodicalPublication;
            this.textBoxAmount.Text = item.Amount;
            this.dateTimePickerOrderFrom.Value = item.OrderFrom;
            this.dateTimePickerOrderTo.Value = item.OrderTo;

        }

        private void viewdetail_Load(object sender, EventArgs e)
        {

        }

    }
}
