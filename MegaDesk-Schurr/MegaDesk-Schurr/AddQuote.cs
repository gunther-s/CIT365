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

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            ComboBox1.DataSource = materials;

            ComboBox1.SelectedIndex = -1;
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
            MessageBox.Show("It was detailed in the Tuesday class that THIS WEEK we just needed the interface to work (see time 1:09:56 on the video). Is that right? Who knows.");
            var desk = new Desk
            {
                //Width = deskWidth.Value,
                //Depth = deskDepth.Value
            };

            //deskQuote.CustomerName - txtCustomerName.Text;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < Desk.MIN_WIDTH)
            {
                numericUpDown2.Value = Desk.MIN_WIDTH;
                MessageBox.Show("Min. width is 24in");
            }
            if (numericUpDown2.Value > Desk.MAX_WIDTH)
            {
                numericUpDown2.Value = Desk.MAX_WIDTH;
                MessageBox.Show("Max width is 96in");
            }
        }

        //Why is this here? See block comment below.
        private void numericUpDown2_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown2.Value < Desk.MIN_WIDTH)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                numericUpDown2.Value = Desk.MIN_WIDTH;
                MessageBox.Show("Min. width is 24in");
            }
            if (numericUpDown2.Value > Desk.MAX_WIDTH)
            {
                e.Cancel = true;
                numericUpDown2.Value = Desk.MAX_WIDTH;
                MessageBox.Show("Max width is 96in");
            }
            else
            {
                e.Cancel = false;
            }
        }

        /* At this point, the instructions say to do a KeyPress event for Depth.
         * However, on Tuesday's class, as recorded in the video "CIT 365 - Spring 2020 - Lesson 3 Day 1" at 1:06:50,
         * the instructor showed how to use the "Minimum" and "Maximum" property for the numeric box, thus allowing us to save "hours" of work.
         * So, since I've already followed those directions, and added my own validation just in case, at the moment
         * I see no reason for me to try to cobble together some KeyPress event.
         */

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value < Desk.MIN_DEPTH)
            {
                numericUpDown3.Value = Desk.MIN_DEPTH;
                MessageBox.Show("Min. depth is 12in");
            }
            if (numericUpDown3.Value > Desk.MAX_DEPTH)
            {
                numericUpDown3.Value = Desk.MAX_DEPTH;
                MessageBox.Show("Max depth is 48in");
            }
        }
    }
}
