namespace User_Interface
{
    partial class PedidoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoUC));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtDataPedido = new System.Windows.Forms.TextBox();
            this.txtStatusPedido = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValorComDesconto = new System.Windows.Forms.TextBox();
            this.txtValorSemDesconto = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblStatusPedido = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblValorComDesconto = new System.Windows.Forms.Label();
            this.lblValorSemDesconto = new System.Windows.Forms.Label();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.TextBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.grvPedido = new System.Windows.Forms.DataGridView();
            this.btnCalculaDesconto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(704, 99);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(46, 41);
            this.btnAtualizar.TabIndex = 206;
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(623, 99);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(44, 41);
            this.btnIncluir.TabIndex = 205;
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(790, 96);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(51, 47);
            this.btnLimpar.TabIndex = 204;
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
            this.btnConsultar.Location = new System.Drawing.Point(539, 96);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(50, 47);
            this.btnConsultar.TabIndex = 203;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDataPedido
            // 
            this.txtDataPedido.Location = new System.Drawing.Point(252, 45);
            this.txtDataPedido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDataPedido.Name = "txtDataPedido";
            this.txtDataPedido.Size = new System.Drawing.Size(180, 25);
            this.txtDataPedido.TabIndex = 3;
            // 
            // txtStatusPedido
            // 
            this.txtStatusPedido.Location = new System.Drawing.Point(711, 45);
            this.txtStatusPedido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtStatusPedido.Name = "txtStatusPedido";
            this.txtStatusPedido.Size = new System.Drawing.Size(114, 25);
            this.txtStatusPedido.TabIndex = 5;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(207, 118);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(85, 25);
            this.txtDesconto.TabIndex = 7;
            // 
            // txtValorComDesconto
            // 
            this.txtValorComDesconto.Location = new System.Drawing.Point(368, 118);
            this.txtValorComDesconto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtValorComDesconto.Name = "txtValorComDesconto";
            this.txtValorComDesconto.Size = new System.Drawing.Size(139, 25);
            this.txtValorComDesconto.TabIndex = 8;
            // 
            // txtValorSemDesconto
            // 
            this.txtValorSemDesconto.Location = new System.Drawing.Point(28, 118);
            this.txtValorSemDesconto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtValorSemDesconto.Name = "txtValorSemDesconto";
            this.txtValorSemDesconto.Size = new System.Drawing.Size(137, 25);
            this.txtValorSemDesconto.TabIndex = 6;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(137, 45);
            this.txtClienteId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(67, 25);
            this.txtClienteId.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(28, 45);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 25);
            this.txtId.TabIndex = 1;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(246, 13);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(112, 17);
            this.lblDataPedido.TabIndex = 187;
            this.lblDataPedido.Text = "Data do pedido*";
            // 
            // lblStatusPedido
            // 
            this.lblStatusPedido.AutoSize = true;
            this.lblStatusPedido.Location = new System.Drawing.Point(707, 14);
            this.lblStatusPedido.Name = "lblStatusPedido";
            this.lblStatusPedido.Size = new System.Drawing.Size(123, 17);
            this.lblStatusPedido.TabIndex = 178;
            this.lblStatusPedido.Text = "Status do pedido*";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(200, 87);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(104, 17);
            this.lblDesconto.TabIndex = 177;
            this.lblDesconto.Text = "Desconto (%)*";
            // 
            // lblValorComDesconto
            // 
            this.lblValorComDesconto.AutoSize = true;
            this.lblValorComDesconto.Location = new System.Drawing.Point(363, 86);
            this.lblValorComDesconto.Name = "lblValorComDesconto";
            this.lblValorComDesconto.Size = new System.Drawing.Size(143, 17);
            this.lblValorComDesconto.TabIndex = 176;
            this.lblValorComDesconto.Text = "Valor com desconto*";
            // 
            // lblValorSemDesconto
            // 
            this.lblValorSemDesconto.AutoSize = true;
            this.lblValorSemDesconto.Location = new System.Drawing.Point(22, 86);
            this.lblValorSemDesconto.Name = "lblValorSemDesconto";
            this.lblValorSemDesconto.Size = new System.Drawing.Size(143, 17);
            this.lblValorSemDesconto.TabIndex = 175;
            this.lblValorSemDesconto.Text = "Valor sem desconto*";
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Location = new System.Drawing.Point(133, 13);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(77, 17);
            this.lblClienteId.TabIndex = 174;
            this.lblClienteId.Text = "Cliente ID*";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(71, 17);
            this.lblId.TabIndex = 173;
            this.lblId.Text = "Pedido ID";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Location = new System.Drawing.Point(474, 45);
            this.txtDataEntrega.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(198, 25);
            this.txtDataEntrega.TabIndex = 4;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(468, 13);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(118, 17);
            this.lblDataEntrega.TabIndex = 208;
            this.lblDataEntrega.Text = "Data da entrega*";
            // 
            // grvPedido
            // 
            this.grvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPedido.Location = new System.Drawing.Point(28, 171);
            this.grvPedido.Name = "grvPedido";
            this.grvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvPedido.Size = new System.Drawing.Size(934, 217);
            this.grvPedido.TabIndex = 209;
            // 
            // btnCalculaDesconto
            // 
            this.btnCalculaDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculaDesconto.FlatAppearance.BorderSize = 0;
            this.btnCalculaDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculaDesconto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculaDesconto.Image")));
            this.btnCalculaDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculaDesconto.Location = new System.Drawing.Point(298, 108);
            this.btnCalculaDesconto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCalculaDesconto.Name = "btnCalculaDesconto";
            this.btnCalculaDesconto.Size = new System.Drawing.Size(43, 44);
            this.btnCalculaDesconto.TabIndex = 210;
            this.btnCalculaDesconto.UseVisualStyleBackColor = true;
            this.btnCalculaDesconto.Click += new System.EventHandler(this.btnCalculaDesconto_Click);
            // 
            // PedidoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCalculaDesconto);
            this.Controls.Add(this.grvPedido);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtDataPedido);
            this.Controls.Add(this.txtStatusPedido);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValorComDesconto);
            this.Controls.Add(this.txtValorSemDesconto);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.lblStatusPedido);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblValorComDesconto);
            this.Controls.Add(this.lblValorSemDesconto);
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PedidoUC";
            this.Size = new System.Drawing.Size(993, 403);
            this.Load += new System.EventHandler(this.PedidoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtDataPedido;
        private System.Windows.Forms.TextBox txtStatusPedido;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValorComDesconto;
        private System.Windows.Forms.TextBox txtValorSemDesconto;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblStatusPedido;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblValorComDesconto;
        private System.Windows.Forms.Label lblValorSemDesconto;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtDataEntrega;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.DataGridView grvPedido;
        private System.Windows.Forms.Button btnCalculaDesconto;
    }
}
