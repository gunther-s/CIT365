﻿namespace MegaDesk_Schurr
{
    partial class SearchQuotes
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
            this.SQExitToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQExitToMain
            // 
            this.SQExitToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQExitToMain.Location = new System.Drawing.Point(302, 383);
            this.SQExitToMain.Name = "SQExitToMain";
            this.SQExitToMain.Size = new System.Drawing.Size(80, 30);
            this.SQExitToMain.TabIndex = 0;
            this.SQExitToMain.Text = "Exit";
            this.SQExitToMain.UseVisualStyleBackColor = true;
            this.SQExitToMain.Click += new System.EventHandler(this.SQExitToMain_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.SQExitToMain);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SQExitToMain;
    }
}