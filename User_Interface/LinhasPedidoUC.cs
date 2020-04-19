using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace User_Interface
{
    public partial class LinhasPedidoUC : UserControl
    {
        public LinhasPedidoUC()
        {
            InitializeComponent();
        }

        private void LinhasPedidoUC_Load(object sender, EventArgs e)
        {
            grvLinhasDoPedido.DataSource = BuscaLinhasDoPedido();
            grvPedido.DataSource = BuscaPedido();
        }

        private DataTable BuscaPedido()
        {
            try
            {
                DataTable dataTable = new DataTable();

                string conexao = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

                using (SqlConnection sqlConnection = new SqlConnection(conexao))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Pedidos", sqlConnection))
                    {
                        sqlConnection.Open();

                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                        dataTable.Load(sqlDataReader);
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            return null;
        }

        private DataTable BuscaLinhasDoPedido()
        {
            try
            {
                DataTable dataTable = new DataTable();

                string conexao = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

                using (SqlConnection sqlConnection = new SqlConnection(conexao))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM LinhasPedidos", sqlConnection))
                    {
                        sqlConnection.Open();

                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                        dataTable.Load(sqlDataReader);
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            return null;
        }
    }
}
