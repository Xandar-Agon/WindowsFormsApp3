namespace WindowsFormsApp4
{
    partial class Form2
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.gb_diff = new System.Windows.Forms.GroupBox();
            this.cb_dificil = new System.Windows.Forms.CheckBox();
            this.cb_medio = new System.Windows.Forms.CheckBox();
            this.cb_facil = new System.Windows.Forms.CheckBox();
            this.gb_diff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(111, 158);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "button1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(98, 132);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(57, 138);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // gb_diff
            // 
            this.gb_diff.Controls.Add(this.cb_dificil);
            this.gb_diff.Controls.Add(this.cb_medio);
            this.gb_diff.Controls.Add(this.cb_facil);
            this.gb_diff.Location = new System.Drawing.Point(46, 26);
            this.gb_diff.Name = "gb_diff";
            this.gb_diff.Size = new System.Drawing.Size(213, 100);
            this.gb_diff.TabIndex = 3;
            this.gb_diff.TabStop = false;
            this.gb_diff.Text = "groupBox1";
            this.gb_diff.Enter += new System.EventHandler(this.gb_diff_Enter);
            // 
            // cb_dificil
            // 
            this.cb_dificil.AutoSize = true;
            this.cb_dificil.Location = new System.Drawing.Point(7, 68);
            this.cb_dificil.Name = "cb_dificil";
            this.cb_dificil.Size = new System.Drawing.Size(80, 17);
            this.cb_dificil.TabIndex = 2;
            this.cb_dificil.Text = "checkBox3";
            this.cb_dificil.UseVisualStyleBackColor = true;
            this.cb_dificil.CheckedChanged += new System.EventHandler(this.cb_dificil_CheckedChanged);
            // 
            // cb_medio
            // 
            this.cb_medio.AutoSize = true;
            this.cb_medio.Location = new System.Drawing.Point(7, 44);
            this.cb_medio.Name = "cb_medio";
            this.cb_medio.Size = new System.Drawing.Size(80, 17);
            this.cb_medio.TabIndex = 1;
            this.cb_medio.Text = "checkBox2";
            this.cb_medio.UseVisualStyleBackColor = true;
            this.cb_medio.CheckedChanged += new System.EventHandler(this.cb_medio_CheckedChanged);
            // 
            // cb_facil
            // 
            this.cb_facil.AutoSize = true;
            this.cb_facil.Location = new System.Drawing.Point(7, 20);
            this.cb_facil.Name = "cb_facil";
            this.cb_facil.Size = new System.Drawing.Size(80, 17);
            this.cb_facil.TabIndex = 0;
            this.cb_facil.Text = "checkBox1";
            this.cb_facil.UseVisualStyleBackColor = true;
            this.cb_facil.CheckedChanged += new System.EventHandler(this.cb_facil_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gb_diff);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_diff.ResumeLayout(false);
            this.gb_diff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox gb_diff;
        private System.Windows.Forms.CheckBox cb_dificil;
        private System.Windows.Forms.CheckBox cb_medio;
        private System.Windows.Forms.CheckBox cb_facil;
    }
}

