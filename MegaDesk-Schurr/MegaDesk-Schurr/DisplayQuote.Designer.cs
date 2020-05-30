namespace MegaDesk_Schurr
{
    partial class DisplayQuote
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
            this.ReturnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnToMain
            // 
            this.ReturnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToMain.Location = new System.Drawing.Point(292, 374);
            this.ReturnToMain.Name = "ReturnToMain";
            this.ReturnToMain.Size = new System.Drawing.Size(100, 40);
            this.ReturnToMain.TabIndex = 0;
            this.ReturnToMain.Text = "Exit";
            this.ReturnToMain.UseVisualStyleBackColor = true;
            this.ReturnToMain.Click += new System.EventHandler(this.ReturnToMain_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.ReturnToMain);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnToMain;
    }
}