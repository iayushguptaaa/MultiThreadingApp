using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreadingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            Thread workThread = new Thread(DoTimeWork);
            workThread.Start();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }


        private void DoTimeWork()
        {
            Thread.Sleep(1000);

            try
            {
                if (btnTimeConsumingWork.InvokeRequired)//cross threading using INVOKE REQUIRED
                {
                    btnTimeConsumingWork.Invoke(new Action(DoTimeWork));
                    return;
                }
                if (listBoxNumbers.Items != null)
                    listBoxNumbers.Items.Clear();

                listBoxNumbers.Items.Add("Do time work Thread");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //num();
        }

        private void num()
        {
            for (int i = 1; i <= 10; i++)
            {
                listBoxNumbers.Items.Add(i);

            }
        }

        private void btnPrintNumbers_Click_1(object sender, EventArgs e)
        {
            num();                       
        }

        private void listBoxNumbers_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
