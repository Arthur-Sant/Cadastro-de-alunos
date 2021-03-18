namespace cad_alunos_04_2d2
{
    partial class frm_aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_aluno));
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.dgv_listar = new System.Windows.Forms.DataGridView();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.lbl_data_nsc = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pct_foto = new System.Windows.Forms.PictureBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.ofd_foto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(15, 36);
            this.lbl_matricula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(69, 17);
            this.lbl_matricula.TabIndex = 0;
            this.lbl_matricula.Text = "Matricula ";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(214, 36);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome ";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(322, 109);
            this.lbl_sexo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(39, 17);
            this.lbl_sexo.TabIndex = 2;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(544, 109);
            this.lbl_nota.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(38, 17);
            this.lbl_nota.TabIndex = 3;
            this.lbl_nota.Text = "Nota";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(217, 57);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(462, 23);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(16, 57);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(132, 23);
            this.txt_matricula.TabIndex = 5;
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(547, 130);
            this.txt_nota.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(132, 23);
            this.txt_nota.TabIndex = 6;
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(15, 132);
            this.dtp_data.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(265, 23);
            this.dtp_data.TabIndex = 7;
            // 
            // dgv_listar
            // 
            this.dgv_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar.Location = new System.Drawing.Point(16, 174);
            this.dgv_listar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_listar.Name = "dgv_listar";
            this.dgv_listar.Size = new System.Drawing.Size(663, 191);
            this.dgv_listar.TabIndex = 8;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cbx_sexo.Location = new System.Drawing.Point(325, 130);
            this.cbx_sexo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(159, 24);
            this.cbx_sexo.TabIndex = 9;
            // 
            // lbl_data_nsc
            // 
            this.lbl_data_nsc.AutoSize = true;
            this.lbl_data_nsc.Location = new System.Drawing.Point(15, 109);
            this.lbl_data_nsc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_data_nsc.Name = "lbl_data_nsc";
            this.lbl_data_nsc.Size = new System.Drawing.Size(134, 17);
            this.lbl_data_nsc.TabIndex = 10;
            this.lbl_data_nsc.Text = "Data de nascimento";
            // 
            // btn_novo
            // 
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(16, 382);
            this.btn_novo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(103, 48);
            this.btn_novo.TabIndex = 11;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(156, 382);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(103, 48);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(296, 382);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(103, 48);
            this.btn_alterar.TabIndex = 13;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(436, 382);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(103, 48);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(576, 382);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(103, 48);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pct_foto
            // 
            this.pct_foto.Cursor = System.Windows.Forms.Cursors.Default;
            this.pct_foto.ImageLocation = "";
            this.pct_foto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pct_foto.InitialImage")));
            this.pct_foto.Location = new System.Drawing.Point(718, 36);
            this.pct_foto.Name = "pct_foto";
            this.pct_foto.Size = new System.Drawing.Size(234, 329);
            this.pct_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_foto.TabIndex = 16;
            this.pct_foto.TabStop = false;
            // 
            // btn_foto
            // 
            this.btn_foto.Image = ((System.Drawing.Image)(resources.GetObject("btn_foto.Image")));
            this.btn_foto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_foto.Location = new System.Drawing.Point(718, 382);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(234, 48);
            this.btn_foto.TabIndex = 17;
            this.btn_foto.Text = "Escolher foto...";
            this.btn_foto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_foto.UseVisualStyleBackColor = true;
            // 
            // ofd_foto
            // 
            this.ofd_foto.FileName = "openFileDialog1";
            // 
            // frm_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 458);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.pct_foto);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.lbl_data_nsc);
            this.Controls.Add(this.cbx_sexo);
            this.Controls.Add(this.dgv_listar);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_matricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.frm_aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.DataGridView dgv_listar;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.Label lbl_data_nsc;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox pct_foto;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.OpenFileDialog ofd_foto;
    }
}

