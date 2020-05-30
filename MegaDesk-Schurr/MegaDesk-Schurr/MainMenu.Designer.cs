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
            this.AddQuotes = new System.Windows.Forms.Button();
            this.AppExit = new System.Windows.Forms.Button();
            this.ViewQuotes = new System.Windows.Forms.Button();
            this.SeachQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuotes
            // 
            this.AddQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuotes.Location = new System.Drawing.Point(57, 44);
            this.AddQuotes.Name = "AddQuotes";
            this.AddQuotes.Size = new System.Drawing.Size(137, 60);
            this.AddQuotes.TabIndex = 0;
            this.AddQuotes.Text = "Create Quote";
            this.AddQuotes.UseVisualStyleBackColor = true;
            this.AddQuotes.Click += new System.EventHandler(this.AddQuotes_Click);
            // 
            // AppExit
            // 
            this.AppExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppExit.Location = new System.Drawing.Point(57, 349);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(137, 30);
            this.AppExit.TabIndex = 1;
            this.AppExit.Text = "Exit";
            this.AppExit.UseVisualStyleBackColor = true;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // ViewQuotes
            // 
            this.ViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotes.Location = new System.Drawing.Point(57, 131);
            this.ViewQuotes.Name = "ViewQuotes";
            this.ViewQuotes.Size = new System.Drawing.Size(137, 60);
            this.ViewQuotes.TabIndex = 2;
            this.ViewQuotes.Text = "View Quotes";
            this.ViewQuotes.UseVisualStyleBackColor = true;
            this.ViewQuotes.Click += new System.EventHandler(this.ViewQuotes_Click);
            // 
            // SeachQuotes
            // 
            this.SeachQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeachQuotes.Location = new System.Drawing.Point(57, 221);
            this.SeachQuotes.Name = "SeachQuotes";
            this.SeachQuotes.Size = new System.Drawing.Size(137, 60);
            this.SeachQuotes.TabIndex = 3;
            this.SeachQuotes.Text = "Search Quotes";
            this.SeachQuotes.UseVisualStyleBackColor = true;
            this.SeachQuotes.Click += new System.EventHandler(this.SeachQuotes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.SeachQuotes);
            this.Controls.Add(this.ViewQuotes);
            this.Controls.Add(this.AppExit);
            this.Controls.Add(this.AddQuotes);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - Schurr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuotes;
        private System.Windows.Forms.Button AppExit;
        private System.Windows.Forms.Button ViewQuotes;
        private System.Windows.Forms.Button SeachQuotes;
    }
}

