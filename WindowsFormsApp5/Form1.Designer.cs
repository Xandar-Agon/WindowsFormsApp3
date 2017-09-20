namespace WindowsFormsApp5
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
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.btn_carrega = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_imagem
            // 
            this.pb_imagem.Location = new System.Drawing.Point(113, 87);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(423, 167);
            this.pb_imagem.TabIndex = 0;
            this.pb_imagem.TabStop = false;
            // 
            // btn_carrega
            // 
            this.btn_carrega.Location = new System.Drawing.Point(273, 260);
            this.btn_carrega.Name = "btn_carrega";
            this.btn_carrega.Size = new System.Drawing.Size(103, 23);
            this.btn_carrega.TabIndex = 1;
            this.btn_carrega.Text = "Carrega Imagem";
            this.btn_carrega.UseVisualStyleBackColor = true;
            this.btn_carrega.Click += new System.EventHandler(this.btn_carrega_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.btn_carrega);
            this.Controls.Add(this.pb_imagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_imagem;
        private System.Windows.Forms.Button btn_carrega;
    }
}

