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
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;
        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void SQExitToMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
            _mainMenu.Show();
        }
    }
}
