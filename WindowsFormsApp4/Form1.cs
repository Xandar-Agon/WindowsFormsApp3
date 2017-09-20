using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int x = 4;
        private int tr = 0;
        private int score = 0;

        public void Setx(int n)
        {
            x = n;
            return;
        }

        public int Getx()
        {
            return x;
        }

        public void Inctry()
        {
            ++tr;
        }

        public int Gettry()
        {
            return tr;
        }

        public void Incscore(int n)
        {
            score += n;
        }

        public int Getscore()
        {
            return score;
        }

        public void Checkwin()
        {
            if (Getscore() >= 25)
            {
                MessageBox.Show("Ganhou");
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int diff = Getx();

            lbl_4.Text = "Nº Tentativas: " + Gettry().ToString();
            lbl_5.Text = "Nº Pontos: " + Getscore().ToString();
            for (int i = 0; i < 20; ++i)
            {
                lbl_1.Text = rand.Next(1, diff + 1).ToString();
                lbl_2.Text = rand.Next(1, diff + 1).ToString();
                lbl_3.Text = rand.Next(1, diff + 1).ToString();
                System.Threading.Thread.Sleep(i * 5);
            }
            if (lbl_1.Text == lbl_2.Text && lbl_2.Text == lbl_3.Text)
            {
                Incscore(5);
            }
            else if (lbl_1.Text == lbl_2.Text || lbl_1.Text == lbl_3.Text || lbl_2.Text == lbl_3.Text)
            {
                Incscore(3);
            }
            Checkwin();
            Inctry();

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_6.Text = "Dificuldade: Fácil";
            Setx(4);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_6.Text = "Dificuldade: Médio";
            Setx(7);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_6.Text = "Dificuldade: Difícil";
            Setx(9);
        }
    }
}
