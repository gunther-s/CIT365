using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Schurr
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
            _mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var desk = new Desk
            {
                //Width = deskWidth.Value,
                //Depth = deskDepth.Value
            };

            //deskQuote.CustomerName - txtCustomerName.Text;

        }

        
    }
}
