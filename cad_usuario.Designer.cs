namespace cad_alunos_04_2d2
{
    partial class cad_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cad_usuario));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_csenha = new System.Windows.Forms.Label();
            this.txt_csenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(55, 41);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(45, 17);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(55, 99);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 17);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(55, 158);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(49, 17);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.Location = new System.Drawing.Point(58, 285);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(159, 44);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(237, 285);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(159, 44);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(58, 62);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(338, 23);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(58, 179);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(338, 23);
            this.txt_senha.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(58, 120);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(338, 23);
            this.txt_email.TabIndex = 8;
            // 
            // lbl_csenha
            // 
            this.lbl_csenha.AutoSize = true;
            this.lbl_csenha.Location = new System.Drawing.Point(55, 215);
            this.lbl_csenha.Name = "lbl_csenha";
            this.lbl_csenha.Size = new System.Drawing.Size(107, 17);
            this.lbl_csenha.TabIndex = 9;
            this.lbl_csenha.Text = "Confirma senha";
            // 
            // txt_csenha
            // 
            this.txt_csenha.Location = new System.Drawing.Point(58, 238);
            this.txt_csenha.Name = "txt_csenha";
            this.txt_csenha.Size = new System.Drawing.Size(338, 23);
            this.txt_csenha.TabIndex = 10;
            // 
            // cad_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 365);
            this.Controls.Add(this.txt_csenha);
            this.Controls.Add(this.lbl_csenha);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cad_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_csenha;
        private System.Windows.Forms.TextBox txt_csenha;
    }
}