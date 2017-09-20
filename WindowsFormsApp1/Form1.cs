using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 1; i < 30; i++)
            {
                lbl_num1.Text = rand.Next(1, 10).ToString();
                System.Threading.Thread.Sleep(i*5);
                this.Update();
            }

            
        }
    }
}
