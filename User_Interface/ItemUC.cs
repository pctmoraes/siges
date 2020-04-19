using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Empresa.Domain.Entities;
using Newtonsoft.Json;

namespace User_Interface
{
    public partial class ItemUC : UserControl
    {
        public ItemUC()
        {
            InitializeComponent();
        }

        private void ItemUC_Load(object sender, EventArgs e)
        {
            grvItem.DataSource = BuscaItens();
        }

        private DataTable BuscaItens()
        {
            try
            {
                DataTable dataTable = new DataTable();

                string conexao = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

                using (SqlConnection sqlConnection = new SqlConnection(conexao))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Items", sqlConnection))
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

        public string uri = "http://localhost:55531/api/Item/";
        
        #region ------ GET BY ID
        private void btnConsultar_Click(object sender, System.EventArgs e)
        {
            if (txtItemId.Text != string.Empty)
            {
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri + txtItemId.Text);
                    HttpResponseMessage response = httpClient.SendAsync(request).Result;
                    response.EnsureSuccessStatusCode();

                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    if(conteudo != "" || conteudo != null)
                    {
                        Item item = new Item();

                        item = JsonConvert.DeserializeObject<Item>(conteudo);
                        {
                            txtCodigo.Text = item.Codigo;
                            txtDescricao.Text = item.Descricao;
                            txtPrecoCompra.Text = item.PrecoDeCompra.ToString();
                            txtPrecoVenda.Text = item.PrecoDeVenda.ToString();
                            txtQuantidade.Text = item.Quantidade.ToString();
                        }

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

        #region ----- POST
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty && txtPrecoCompra.Text != string.Empty && txtPrecoVenda.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
                Item item = new Item()
                {
                    Codigo = txtCodigo.Text,
                    Descricao = txtDescricao.Text,
                    PrecoDeCompra = (Convert.ToDouble(txtPrecoCompra.Text))/100,
                    PrecoDeVenda = (Convert.ToDouble(txtPrecoVenda.Text))/100,
                    Quantidade = Convert.ToInt16(txtQuantidade.Text)
                };

                try
                {
                    string conteudo = JsonConvert.SerializeObject(item);

                    var stringContent = new StringContent(conteudo, Encoding.UTF8, "application/json");

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);
                    HttpResponseMessage response = httpClient.PostAsync(uri, stringContent).Result;
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Item cadastrado com sucesso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível incluir o item, verifique conexão.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Campos com asterisco * são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region ------ PUT
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty && txtPrecoCompra.Text != string.Empty && txtPrecoVenda.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
                try
                {
                    Item item = new Item()
                    {
                        Codigo = txtCodigo.Text,
                        Descricao = txtDescricao.Text,
                        PrecoDeCompra = (Convert.ToDouble(txtPrecoCompra.Text)) / 100,
                        PrecoDeVenda = (Convert.ToDouble(txtPrecoVenda.Text)) / 100,
                        Quantidade = Convert.ToInt16(txtQuantidade.Text)
                    };

                    string conteudo = JsonConvert.SerializeObject(item);

                    var stringContent = new StringContent(conteudo, Encoding.UTF8, "application/json");

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, uri);
                    HttpResponseMessage resposta = httpClient.PutAsync(uri, stringContent).Result;
                    resposta.EnsureSuccessStatusCode();

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Item atualizado com sucesso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível atualizar o item, verifique conexão." + ex.ToString(), "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Campos com asterisco * são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region ------ DELETE
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text != string.Empty)
            {
                try
                {
                    string endpoint = uri + txtItemId.Text;
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, uri);
                    HttpResponseMessage response = httpClient.DeleteAsync(endpoint).Result;
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Item excluído com sucesso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("O Item informado não existe no banco de dados.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Insira o ID do Item para excluir.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            txtItemId.Clear();
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtPrecoCompra.Clear();
            txtPrecoVenda.Clear();
            txtQuantidade.Clear();
            txtItemId.Focus();
        }

    }
}
