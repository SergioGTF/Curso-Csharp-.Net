namespace MinhaAplicacao
{
    partial class FrmMeuSistema
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOk = new System.Windows.Forms.Button();
            this.BotãoCancelar = new System.Windows.Forms.Button();
            this.txtfrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(152, 153);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(53, 24);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotãoCancelar
            // 
            this.BotãoCancelar.Location = new System.Drawing.Point(537, 154);
            this.BotãoCancelar.Name = "BotãoCancelar";
            this.BotãoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotãoCancelar.TabIndex = 1;
            this.BotãoCancelar.Text = "Cancelar";
            this.BotãoCancelar.UseVisualStyleBackColor = true;
            // 
            // txtfrase
            // 
            this.txtfrase.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtfrase.Location = new System.Drawing.Point(152, 42);
            this.txtfrase.Name = "txtfrase";
            this.txtfrase.Size = new System.Drawing.Size(460, 22);
            this.txtfrase.TabIndex = 2;
            this.txtfrase.Text = "Digite seu nome";
            this.txtfrase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmMeuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.txtfrase);
            this.Controls.Add(this.BotãoCancelar);
            this.Controls.Add(this.BtnOk);
            this.Name = "FrmMeuSistema";
            this.Text = "Aplicação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BotãoCancelar;
        private System.Windows.Forms.TextBox txtfrase;
    }
}

