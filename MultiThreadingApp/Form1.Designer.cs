﻿
namespace MultiThreadingApp
{
    partial class Form1
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
            this.btnTimeConsumingWork = new System.Windows.Forms.Button();
            this.btnPrintNumbers = new System.Windows.Forms.Button();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTimeConsumingWork
            // 
            this.btnTimeConsumingWork.Location = new System.Drawing.Point(204, 30);
            this.btnTimeConsumingWork.Name = "btnTimeConsumingWork";
            this.btnTimeConsumingWork.Size = new System.Drawing.Size(181, 41);
            this.btnTimeConsumingWork.TabIndex = 0;
            this.btnTimeConsumingWork.Text = "Do Time Consuming Work";
            this.btnTimeConsumingWork.UseVisualStyleBackColor = true;
            this.btnTimeConsumingWork.Click += new System.EventHandler(this.btnTimeConsumingWork_Click);
            // 
            // btnPrintNumbers
            // 
            this.btnPrintNumbers.Location = new System.Drawing.Point(204, 89);
            this.btnPrintNumbers.Name = "btnPrintNumbers";
            this.btnPrintNumbers.Size = new System.Drawing.Size(181, 41);
            this.btnPrintNumbers.TabIndex = 1;
            this.btnPrintNumbers.Text = "Print Numbers 1 to 10";
            this.btnPrintNumbers.UseVisualStyleBackColor = true;
            this.btnPrintNumbers.Click += new System.EventHandler(this.btnPrintNumbers_Click_1);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.Location = new System.Drawing.Point(204, 176);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(181, 160);
            this.listBoxNumbers.TabIndex = 2;
            this.listBoxNumbers.SelectedIndexChanged += new System.EventHandler(this.listBoxNumbers_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(578, 379);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.btnPrintNumbers);
            this.Controls.Add(this.btnTimeConsumingWork);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button work_button;
        private System.Windows.Forms.Button num_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnTimeConsumingWork;
        private System.Windows.Forms.Button btnPrintNumbers;
        private System.Windows.Forms.ListBox listBoxNumbers;
    }
}

