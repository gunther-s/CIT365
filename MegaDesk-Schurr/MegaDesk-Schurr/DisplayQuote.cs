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
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;
        public DisplayQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            //_deskQuote = deskQuote;
        }

        private void ReturnToMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
            _mainMenu.Show();
        }
    }
}
