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
    public partial class mainUI : Form
    {
        Boolean thoat = true;
        private List<Order> orders = new List<Order>();
        public mainUI()
        {
            InitializeComponent();
            counter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thoat = false;
            login f = new login();
            this.Close();
            f.Show();
        }

        private void mainUI_Load(object sender, EventArgs e)
        {

        }

        private void mainUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thoat)
                Application.Exit();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
                exe();
                counter();
        }

        private void exe()
        {
            Order newOrder = new Order
            {
                FormID = textBoxFormID.Text,
                Date = dateTimePickerDate.Value,
                CustomerID = textBoxCustomerID.Text,
                CustomerName = textBoxCustomerName.Text,
                Address = textBoxAddress.Text,
                NewspaperID = textBoxNewspaperID.Text,
                NewspaperName = textBoxNewspaperName.Text,
                PeriodicalPublication = textBoxPeriodicalPublication.Text,
                Amount = textBoxAmount.Text,
                OrderFrom = dateTimePickerOrderFrom.Value,
                OrderTo = dateTimePickerOrderTo.Value
            };
            orders.Add(newOrder);
            RefreshList();
            ClearList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshList()
        {
            OrderListBox.Items.Clear();
            {
                foreach (Order order in orders)
                { 
                    OrderListBox.Items.Add(order);
                }
            }
        }

        private void ClearList()
        {
            textBoxFormID.Clear();
            textBoxCustomerID.Clear();
            textBoxCustomerName.Clear();
            textBoxAddress.Clear();
            textBoxPeriodicalPublication.Clear();
            textBoxNewspaperID.Clear();
            textBoxNewspaperName.Clear();
            textBoxAmount.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(OrderListBox.SelectedItems.Count != -1) 
            {
                Order selectedItem = orders[OrderListBox.SelectedIndex];
                viewdetail a = new viewdetail(selectedItem);
                a.ShowDialog();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            OrderListBox.Items.Clear();
            counter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OrderListBox.SelectedItems.Count != null)
            {
                OrderListBox.Items.Remove(orders[OrderListBox.SelectedIndex]);
                counter();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void counter()
        {
            int price = OrderListBox.Items.Count * 200000;
            Display.Text = price.ToString("C");
        }
    }
}
