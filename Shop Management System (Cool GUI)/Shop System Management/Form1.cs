using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_System_Management
{
    public partial class Form1 : Form
    {
        PlaceOrder place = new PlaceOrder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            place.Show();
            place.Dock = DockStyle.Fill;
            screenPanel.Controls.Add(place);
        }
    }
}
