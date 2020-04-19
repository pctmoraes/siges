namespace User_Interface
{
    partial class ClientUC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientUC));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtSituacaoCadastral = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtNomeEmpresarial = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblSituacaoCadastral = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblPorte = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblNomeEmpresarial = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(900, 11);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(51, 47);
            this.btnLimpar.TabIndex = 137;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(553, 11);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(50, 47);
            this.btnConsultar.TabIndex = 136;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtSituacaoCadastral
            // 
            this.txtSituacaoCadastral.Location = new System.Drawing.Point(378, 37);
            this.txtSituacaoCadastral.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSituacaoCadastral.Name = "txtSituacaoCadastral";
            this.txtSituacaoCadastral.Size = new System.Drawing.Size(119, 25);
            this.txtSituacaoCadastral.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(819, 209);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(140, 25);
            this.txtTelefone.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(585, 209);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 25);
            this.txtEmail.TabIndex = 14;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(483, 209);
            this.txtUf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(60, 25);
            this.txtUf.TabIndex = 13;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(256, 209);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(186, 25);
            this.txtMunicipio.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(31, 209);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(186, 25);
            this.txtBairro.TabIndex = 11;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(811, 151);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(148, 25);
            this.txtCep.TabIndex = 10;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(584, 151);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(191, 25);
            this.txtComplemento.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(424, 151);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(119, 25);
            this.txtNumero.TabIndex = 8;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(195, 151);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(191, 25);
            this.txtLogradouro.TabIndex = 7;
            // 
            // txtPorte
            // 
            this.txtPorte.Location = new System.Drawing.Point(31, 151);
            this.txtPorte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(126, 25);
            this.txtPorte.TabIndex = 6;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(514, 94);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(445, 25);
            this.txtNomeFantasia.TabIndex = 5;
            // 
            // txtNomeEmpresarial
            // 
            this.txtNomeEmpresarial.Location = new System.Drawing.Point(31, 94);
            this.txtNomeEmpresarial.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNomeEmpresarial.Name = "txtNomeEmpresarial";
            this.txtNomeEmpresarial.Size = new System.Drawing.Size(445, 25);
            this.txtNomeEmpresarial.TabIndex = 4;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(144, 37);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(191, 25);
            this.txtCnpj.TabIndex = 2;
            // 
            // lblSituacaoCadastral
            // 
            this.lblSituacaoCadastral.AutoSize = true;
            this.lblSituacaoCadastral.Location = new System.Drawing.Point(372, 13);
            this.lblSituacaoCadastral.Name = "lblSituacaoCadastral";
            this.lblSituacaoCadastral.Size = new System.Drawing.Size(132, 17);
            this.lblSituacaoCadastral.TabIndex = 120;
            this.lblSituacaoCadastral.Text = "Situação Cadastral";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(815, 185);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 17);
            this.lblTelefone.TabIndex = 119;
            this.lblTelefone.Text = "Telefone*";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(579, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 118;
            this.lblEmail.Text = "E-mail";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(479, 185);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 17);
            this.lblUf.TabIndex = 117;
            this.lblUf.Text = "UF";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(250, 185);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(74, 17);
            this.lblMunicipio.TabIndex = 116;
            this.lblMunicipio.Text = "Município*";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(25, 185);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(53, 17);
            this.lblBairro.TabIndex = 115;
            this.lblBairro.Text = "Bairro*";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(807, 128);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(45, 17);
            this.lblCep.TabIndex = 114;
            this.lblCep.Text = "CEP*";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(577, 128);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(100, 17);
            this.lblComplemento.TabIndex = 113;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(418, 128);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 17);
            this.lblNumero.TabIndex = 112;
            this.lblNumero.Text = "Número*";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(191, 128);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(88, 17);
            this.lblLogradouro.TabIndex = 111;
            this.lblLogradouro.Text = "Logradouro*";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Location = new System.Drawing.Point(25, 128);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(49, 17);
            this.lblPorte.TabIndex = 110;
            this.lblPorte.Text = "Porte*";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(509, 70);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(113, 17);
            this.lblNomeFantasia.TabIndex = 109;
            this.lblNomeFantasia.Text = "Nome Fantasia*";
            // 
            // lblNomeEmpresarial
            // 
            this.lblNomeEmpresarial.AutoSize = true;
            this.lblNomeEmpresarial.Location = new System.Drawing.Point(25, 70);
            this.lblNomeEmpresarial.Name = "lblNomeEmpresarial";
            this.lblNomeEmpresarial.Size = new System.Drawing.Size(136, 17);
            this.lblNomeEmpresarial.TabIndex = 108;
            this.lblNomeEmpresarial.Text = "Nome Empresarial*";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(140, 13);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(52, 17);
            this.lblCnpj.TabIndex = 107;
            this.lblCnpj.Text = "CNPJ*";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 17);
            this.lblId.TabIndex = 106;
            this.lblId.Text = "ID";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(637, 14);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(44, 41);
            this.btnIncluir.TabIndex = 139;
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(814, 14);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(46, 41);
            this.btnAtualizar.TabIndex = 140;
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(724, 14);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 41);
            this.btnExcluir.TabIndex = 172;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(31, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(70, 25);
            this.txtId.TabIndex = 1;
            // 
            // grvClientes
            // 
            this.grvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvClientes.Location = new System.Drawing.Point(28, 247);
            this.grvClientes.Name = "grvClientes";
            this.grvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvClientes.Size = new System.Drawing.Size(931, 147);
            this.grvClientes.TabIndex = 173;
            // 
            // ClientUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grvClientes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtSituacaoCadastral);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtPorte);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.txtNomeEmpresarial);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblSituacaoCadastral);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblPorte);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.lblNomeEmpresarial);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ClientUC";
            this.Size = new System.Drawing.Size(993, 403);
            this.Load += new System.EventHandler(this.ClientUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtSituacaoCadastral;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtPorte;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtNomeEmpresarial;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblSituacaoCadastral;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblNomeEmpresarial;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView grvClientes;
    }
}
