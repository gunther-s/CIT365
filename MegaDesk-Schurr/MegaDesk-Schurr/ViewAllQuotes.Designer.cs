namespace MegaDesk_Schurr
{
    partial class ViewAllQuotes
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
            this.VCExitToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VCExitToMain
            // 
            this.VCExitToMain.Location = new System.Drawing.Point(292, 380);
            this.VCExitToMain.Name = "VCExitToMain";
            this.VCExitToMain.Size = new System.Drawing.Size(100, 40);
            this.VCExitToMain.TabIndex = 0;
            this.VCExitToMain.Text = "Exit";
            this.VCExitToMain.UseVisualStyleBackColor = true;
            this.VCExitToMain.Click += new System.EventHandler(this.VCExitToMain_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.VCExitToMain);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VCExitToMain;
    }
}