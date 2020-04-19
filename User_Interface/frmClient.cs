using System;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void AdicionaControleUsuario(Control control)
        {
            control.Dock = DockStyle.Fill;
            pnlControle.Controls.Clear();
            picImage.Hide();
            pnlControle.Controls.Add(control);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClientUC clientUC = new ClientUC();
            AdicionaControleUsuario(clientUC);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemUC itemUC = new ItemUC();
            AdicionaControleUsuario(itemUC);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            PedidoUC pedidoUC = new PedidoUC();
            AdicionaControleUsuario(pedidoUC);
        }

        private void btnLinhasPedidoVendas_Click(object sender, EventArgs e)
        {
            LinhasPedidoUC linhasPedidoUC = new LinhasPedidoUC();
            AdicionaControleUsuario(linhasPedidoUC);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlControle.Controls.Clear();
            picImage.Show();
        }

    }
}
