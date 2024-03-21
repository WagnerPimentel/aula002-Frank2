namespace aula002_Frank2
{
    partial class Form1
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
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.textBox_telefone = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.textBox_cep = new System.Windows.Forms.TextBox();
            this.textBox_cidade = new System.Windows.Forms.TextBox();
            this.textBox_estado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_nome
            // 
            this.textBox_nome.BackColor = System.Drawing.Color.MintCream;
            this.textBox_nome.Location = new System.Drawing.Point(217, 98);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(260, 26);
            this.textBox_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_nome.Location = new System.Drawing.Point(116, 98);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_telefone.Location = new System.Drawing.Point(116, 141);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(71, 20);
            this.lbl_telefone.TabIndex = 2;
            this.lbl_telefone.Text = "Telefone";
            // 
            // textBox_telefone
            // 
            this.textBox_telefone.BackColor = System.Drawing.Color.MintCream;
            this.textBox_telefone.Location = new System.Drawing.Point(217, 141);
            this.textBox_telefone.Name = "textBox_telefone";
            this.textBox_telefone.Size = new System.Drawing.Size(260, 26);
            this.textBox_telefone.TabIndex = 3;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_cep.Location = new System.Drawing.Point(116, 185);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(41, 20);
            this.lbl_cep.TabIndex = 4;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_cidade.Location = new System.Drawing.Point(116, 227);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(59, 20);
            this.lbl_cidade.TabIndex = 5;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_estado.Location = new System.Drawing.Point(116, 269);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(60, 20);
            this.lbl_estado.TabIndex = 6;
            this.lbl_estado.Text = "Estado";
            this.lbl_estado.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_cep
            // 
            this.textBox_cep.BackColor = System.Drawing.Color.MintCream;
            this.textBox_cep.Location = new System.Drawing.Point(217, 185);
            this.textBox_cep.Name = "textBox_cep";
            this.textBox_cep.Size = new System.Drawing.Size(260, 26);
            this.textBox_cep.TabIndex = 7;
            // 
            // textBox_cidade
            // 
            this.textBox_cidade.BackColor = System.Drawing.Color.MintCream;
            this.textBox_cidade.Location = new System.Drawing.Point(217, 227);
            this.textBox_cidade.Name = "textBox_cidade";
            this.textBox_cidade.Size = new System.Drawing.Size(260, 26);
            this.textBox_cidade.TabIndex = 8;
            // 
            // textBox_estado
            // 
            this.textBox_estado.BackColor = System.Drawing.Color.MintCream;
            this.textBox_estado.Location = new System.Drawing.Point(217, 269);
            this.textBox_estado.Name = "textBox_estado";
            this.textBox_estado.Size = new System.Drawing.Size(75, 26);
            this.textBox_estado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 578);
            this.Controls.Add(this.textBox_estado);
            this.Controls.Add(this.textBox_cidade);
            this.Controls.Add(this.textBox_cep);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.textBox_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.textBox_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox textBox_telefone;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox textBox_cep;
        private System.Windows.Forms.TextBox textBox_cidade;
        private System.Windows.Forms.TextBox textBox_estado;
    }
}

