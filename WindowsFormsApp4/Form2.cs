using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        WindowsFormsApp2.Form1 form_game = new WindowsFormsApp2.Form1();

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            
        }

        private void gb_diff_Enter(object sender, EventArgs e)
        {

        }

        private void cb_facil_CheckedChanged(object sender, EventArgs e)
        {
            cb_medio.Checked = false;
            cb_dificil.Checked = false;
            form_game.Setx(4);
        }

        private void cb_medio_CheckedChanged(object sender, EventArgs e)
        {
            cb_facil.Checked = false;
            cb_dificil.Checked = false;
            form_game.Setx(7);
        }

        private void cb_dificil_CheckedChanged(object sender, EventArgs e)
        {
            form_game.Setx(9);
        }
    }
}
