using Empresa.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class PedidoUC : UserControl
    {
        public PedidoUC()
        {
            InitializeComponent();
        }

        private void PedidoUC_Load(object sender, EventArgs e)
        {
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

        public HttpClient httpClient = new HttpClient();

        public string uri = "http://localhost:55531/api/Pedido/";

        #region ------ GET
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri + txtId.Text);
                    HttpResponseMessage response = httpClient.SendAsync(request).Result;
                    response.EnsureSuccessStatusCode();

                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    if (conteudo != "" || conteudo != null)
                    {
                        Pedido pedido = new Pedido();

                        pedido = JsonConvert.DeserializeObject<Pedido>(conteudo);
                        {
                            txtDataPedido.Text = pedido.DataDoPedido.ToString();
                            txtDataEntrega.Text = pedido.DataDaEntrega.ToString();
                            txtValorSemDesconto.Text = pedido.ValorSemDesconto.ToString();
                            txtValorComDesconto.Text = pedido.ValorComDesconto.ToString();
                            txtDesconto.Text = pedido.Desconto.ToString();
                            txtStatusPedido.Text = pedido.Status;
                        };

                    }
                    else
                        MessageBox.Show("Não foi possível conectar-se ao banco de dados, verifique conexão.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("O item consultado não existe no banco de dados." + ex.ToString(), "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region ------ POST
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtClienteId.Text != string.Empty && txtDataPedido.Text != string.Empty && txtDataEntrega.Text != string.Empty && txtValorSemDesconto.Text != string.Empty && txtValorComDesconto.Text != string.Empty && txtDesconto.Text != string.Empty && txtStatusPedido.Text != string.Empty)
            {
                Pedido pedido = new Pedido()
                {
                    DataDoPedido = Convert.ToDateTime(txtDataPedido.Text),
                    DataDaEntrega = Convert.ToDateTime(txtDataEntrega.Text),
                    ValorSemDesconto = Convert.ToDouble(txtValorSemDesconto.Text),
                    ValorComDesconto = Convert.ToDouble(txtValorComDesconto.Text),
                    Desconto = Convert.ToInt32(txtDesconto.Text),
                    Status = txtStatusPedido.Text
                };

                try
                {
                    string conteudo = JsonConvert.SerializeObject(pedido);

                    var stringContent = new StringContent(conteudo, Encoding.UTF8, "application/json");

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);
                    HttpResponseMessage response = httpClient.PostAsync(uri, stringContent).Result;
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Pedido cadastrado com sucesso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch 
                {
                    MessageBox.Show("Não foi possível incluir o pedido, verifique conexão.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Campos com asterisco * são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region ------ PUT
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtClienteId.Text != string.Empty && txtDataPedido.Text != string.Empty && txtDataEntrega.Text != string.Empty && txtValorSemDesconto.Text != string.Empty && txtValorComDesconto.Text != string.Empty && txtDesconto.Text != string.Empty && txtStatusPedido.Text != string.Empty)
            {
                
                try
                {
                    Pedido pedido = new Pedido()
                    {
                        DataDoPedido = Convert.ToDateTime(txtDataPedido.Text),
                        DataDaEntrega = Convert.ToDateTime(txtDataEntrega.Text),
                        ValorSemDesconto = Convert.ToDouble(txtValorSemDesconto.Text),
                        ValorComDesconto = Convert.ToDouble(txtValorComDesconto.Text),
                        Desconto = Convert.ToInt32(txtDesconto.Text),
                        Status = txtStatusPedido.Text
                    };

                    string conteudo = JsonConvert.SerializeObject(pedido);

                    var stringContent = new StringContent(conteudo, Encoding.UTF8, "application/json");

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, uri);
                    HttpResponseMessage resposta = httpClient.PutAsync(uri, stringContent).Result;
                    resposta.EnsureSuccessStatusCode();

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Pedido atualizado com sucesso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível atualizar o pedido, verifique conexão." + ex.ToString(), "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Campos com asterisco * são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region ------ DELETE
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                try
                {
                    string endpoint = uri + txtId.Text;
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, uri);
                    HttpResponseMessage response = httpClient.DeleteAsync(endpoint).Result;
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Pedido excluído com sucesso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("O Pedido informado não existe no banco de dados.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Insira o ID do Pedido para excluir.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        private void btnCalculaDesconto_Click(object sender, EventArgs e)
        {
            if (txtValorSemDesconto.Text != string.Empty && txtDesconto.Text != string.Empty)
            {
                double desconto = (100 - Convert.ToInt32(txtDesconto.Text)) / 100.00;
                txtValorComDesconto.Text = (Convert.ToDouble(txtValorSemDesconto.Text) * desconto).ToString();
            }
            else
                MessageBox.Show("Insira o valor e o desconto do pedido para calcular o valor final.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtClienteId.Clear();
            txtDataPedido.Clear();
            txtDataEntrega.Clear();
            txtValorSemDesconto.Clear();
            txtValorComDesconto.Clear();
            txtDesconto.Clear();
            txtStatusPedido.Clear();
            txtId.Focus();
        }
    }
}
