﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mensagem_Click(object sender, EventArgs e)
        {
            int resposta;
            resposta = Convert.ToInt16(MessageBox.Show("Deseja Sair??", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (resposta == 6)
            {
                Application.Exit();
            }
        }
    }
}
