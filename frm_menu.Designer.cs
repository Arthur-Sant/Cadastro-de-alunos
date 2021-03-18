namespace cad_alunos_04_2d2
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(145, 50);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(282, 23);
            this.txt_email.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(145, 102);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(282, 23);
            this.txt_senha.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_usuario.Location = new System.Drawing.Point(68, 50);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(50, 18);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "E-mail";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_senha.Location = new System.Drawing.Point(68, 102);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(50, 18);
            this.lbl_senha.TabIndex = 3;
            this.lbl_senha.Text = "Senha";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.Location = new System.Drawing.Point(264, 161);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(163, 53);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_entrar.Image")));
            this.btn_entrar.Location = new System.Drawing.Point(71, 161);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(163, 53);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_entrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 283);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_email);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_entrar;
    }
}