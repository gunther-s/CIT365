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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuotes_Click(object sender, EventArgs e)
        {
            var frmAddQuote = new AddQuote(this);
            frmAddQuote.Tag = this;
            frmAddQuote.Show();

            Hide();
        }
        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            var frmViewAllQuotes = new ViewAllQuotes(this);
            frmViewAllQuotes.Tag = this;
            frmViewAllQuotes.Show();

            Hide();
        }

        private void SeachQuotes_Click(object sender, EventArgs e)
        {
            var frmSearchQuotes = new SearchQuotes(this);
            frmSearchQuotes.Tag = this;
            frmSearchQuotes.Show();

            Hide();
        }

        private void AppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
