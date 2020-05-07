namespace MegaDesk_Schurr
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.appExit = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.seachQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // appExit
            // 
            this.appExit.Location = new System.Drawing.Point(107, 394);
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(75, 23);
            this.appExit.TabIndex = 1;
            this.appExit.Text = "Exit";
            this.appExit.UseVisualStyleBackColor = true;
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.Location = new System.Drawing.Point(57, 131);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(75, 23);
            this.viewQuotes.TabIndex = 2;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            // 
            // seachQuotes
            // 
            this.seachQuotes.Location = new System.Drawing.Point(57, 221);
            this.seachQuotes.Name = "seachQuotes";
            this.seachQuotes.Size = new System.Drawing.Size(100, 23);
            this.seachQuotes.TabIndex = 3;
            this.seachQuotes.Text = "Search Quotes";
            this.seachQuotes.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seachQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.appExit);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - Schurr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button appExit;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button seachQuotes;
    }
}

