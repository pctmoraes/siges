namespace User_Interface
{
    partial class LinhasPedidoUC
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
            this.grvLinhasDoPedido = new System.Windows.Forms.DataGridView();
            this.lblLinhasPedidos = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.grvPedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvLinhasDoPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLinhasDoPedido
            // 
            this.grvLinhasDoPedido.AllowUserToAddRows = false;
            this.grvLinhasDoPedido.AllowUserToDeleteRows = false;
            this.grvLinhasDoPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvLinhasDoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLinhasDoPedido.Location = new System.Drawing.Point(8, 183);
            this.grvLinhasDoPedido.Name = "grvLinhasDoPedido";
            this.grvLinhasDoPedido.ReadOnly = true;
            this.grvLinhasDoPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvLinhasDoPedido.Size = new System.Drawing.Size(977, 212);
            this.grvLinhasDoPedido.TabIndex = 0;
            // 
            // lblLinhasPedidos
            // 
            this.lblLinhasPedidos.AutoSize = true;
            this.lblLinhasPedidos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinhasPedidos.Location = new System.Drawing.Point(5, 163);
            this.lblLinhasPedidos.Name = "lblLinhasPedidos";
            this.lblLinhasPedidos.Size = new System.Drawing.Size(208, 18);
            this.lblLinhasPedidos.TabIndex = 1;
            this.lblLinhasPedidos.Text = "Linhas do Pedido de Vendas";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(5, 6);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(58, 18);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "Pedido";
            // 
            // grvPedido
            // 
            this.grvPedido.AllowUserToAddRows = false;
            this.grvPedido.AllowUserToDeleteRows = false;
            this.grvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPedido.Location = new System.Drawing.Point(8, 26);
            this.grvPedido.Name = "grvPedido";
            this.grvPedido.ReadOnly = true;
            this.grvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvPedido.Size = new System.Drawing.Size(977, 108);
            this.grvPedido.TabIndex = 3;
            // 
            // LinhasPedidoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grvPedido);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.lblLinhasPedidos);
            this.Controls.Add(this.grvLinhasDoPedido);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LinhasPedidoUC";
            this.Size = new System.Drawing.Size(993, 403);
            this.Load += new System.EventHandler(this.LinhasPedidoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvLinhasDoPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvLinhasDoPedido;
        private System.Windows.Forms.Label lblLinhasPedidos;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.DataGridView grvPedido;
    }
}
