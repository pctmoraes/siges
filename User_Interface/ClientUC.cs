using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace User_Interface
{
    public partial class ClientUC : UserControl
    {
        public ClientUC()
        {
            InitializeComponent();
        }

        private void ClientUC_Load(object sender, EventArgs e)
        {
            grvClientes.DataSource = BuscaClientes();
        }

        private DataTable BuscaClientes()
        {
            try
            {
                DataTable dataTable = new DataTable();

                string conexao = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

                using (SqlConnection sqlConnection = new SqlConnection(conexao))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Empresas", sqlConnection))
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

        public string uri = "http://localhost:55531/api/Empresas/";

        #region ------ GET BY CNPJ
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != string.Empty)
            {
                try
                {
                    string cnpj = txtCnpj.Text.Trim().Replace(".", "").Replace("/", "").Replace("-", "");
                    
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri + cnpj);
                    HttpResponseMessage resposta = httpClient.SendAsync(request).Result;
                    resposta.EnsureSuccessStatusCode();

                    string conteudo = resposta.Content.ReadAsStringAsync().Result;

                    if (conteudo != "")
                    {
                        Empresa.Domain.Entities.Empresa empresa = new Empresa.Domain.Entities.Empresa(cnpj);

                        empresa = JsonConvert.DeserializeObject<Empresa.Domain.Entities.Empresa>(conteudo);
                        {
                            txtId.Text = (empresa.Id).ToString();
                            txtCnpj.Text = empresa.Cnpj;
                            txtNomeEmpresarial.Text = empresa.NomeEmpresarial;
                            txtNomeFantasia.Text = empresa.NomeFantasia;
                            txtPorte.Text = empresa.Porte;
                            txtLogradouro.Text = empresa.Logradouro;
                            txtNumero.Text = empresa.Numero;
                            txtComplemento.Text = empresa.Complemento;
                            txtCep.Text = empresa.Cep;
                            txtBairro.Text = empresa.Bairro;
                            txtMunicipio.Text = empresa.Municipio;
                            txtUf.Text = empresa.Uf;
                            txtEmail.Text = empresa.Email;
                            txtTelefone.Text = empresa.Telefone;
                            txtSituacaoCadastral.Text = empresa.SituacaoCadastral;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A empresa consultada não existe no banco de dados.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao conectar-se com o banco de dados." + ex.ToString(), "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Insira o CNPJ da Empresa para consultar.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region ------ POST
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != string.Empty && txtNomeEmpresarial.Text != string.Empty && txtNomeFantasia.Text != string.Empty && txtPorte.Text != string.Empty
                && txtLogradouro.Text != string.Empty && txtNumero.Text != string.Empty && txtCep.Text != string.Empty && txtBairro.Text != string.Empty
                && txtMunicipio.Text != string.Empty && txtTelefone.Text != string.Empty)
            {
                string cnpj = txtCnpj.Text.Trim().Replace(".","").Replace("/","").Replace("-","");

                Empresa.Domain.Entities.Empresa empresa = new Empresa.Domain.Entities.Empresa(cnpj)
                {
                    NomeEmpresarial = txtNomeEmpresarial.Text,
                    NomeFantasia = txtNomeFantasia.Text,
                    Porte = txtPorte.Text,
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text,
                    Cep = txtCep.Text,
                    Bairro = txtBairro.Text,
                    Municipio = txtMunicipio.Text,
                    Uf = txtUf.Text,
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text
                };

                try
                {
                    string conteudo = JsonConvert.SerializeObject(empresa);

                    var stringContent = new StringContent(conteudo, Encoding.UTF8, "application/json");

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);
                    HttpResponseMessage resposta = httpClient.PostAsync(uri, stringContent).Result;
                    resposta.EnsureSuccessStatusCode();

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Empresa cadastrada com sucesso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível incluir a empresa, verifique conexão.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Campos com asterisco * são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region ------ PUT
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != string.Empty && txtNomeEmpresarial.Text != string.Empty && txtNomeFantasia.Text != string.Empty && txtPorte.Text != string.Empty
                && txtLogradouro.Text != string.Empty && txtNumero.Text != string.Empty && txtCep.Text != string.Empty && txtBairro.Text != string.Empty
                && txtMunicipio.Text != string.Empty && txtTelefone.Text != string.Empty)
            {
                try
                {
                    string cnpj = txtCnpj.Text.Trim().Replace(".", "").Replace("/", "").Replace("-", "");

                    Empresa.Domain.Entities.Empresa empresa = new Empresa.Domain.Entities.Empresa(cnpj)
                    {
                        NomeEmpresarial = txtNomeEmpresarial.Text,
                        NomeFantasia = txtNomeFantasia.Text,
                        Porte = txtPorte.Text,
                        Logradouro = txtLogradouro.Text,
                        Numero = txtNumero.Text,
                        Complemento = txtComplemento.Text,
                        Cep = txtCep.Text,
                        Bairro = txtBairro.Text,
                        Municipio = txtMunicipio.Text,
                        Uf = txtUf.Text,
                        Email = txtEmail.Text,
                        Telefone = txtTelefone.Text
                    };

                    string conteudo = JsonConvert.SerializeObject(empresa);

                    var stringContent = new StringContent(conteudo, Encoding.UTF8, "application/json");

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, uri);
                    HttpResponseMessage resposta = httpClient.PutAsync(uri, stringContent).Result;
                    resposta.EnsureSuccessStatusCode();

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Empresa atualizada com sucesso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível atualizar a empresa, verifique conexão." + ex.ToString(), "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Campos com asterisco * são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region ------ DELETE
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != string.Empty)
            {
                try
                {
                    string endpoint = uri + txtCnpj.Text;
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, uri);
                    HttpResponseMessage resposta = httpClient.DeleteAsync(endpoint).Result;
                    resposta.EnsureSuccessStatusCode();
                }
                catch
                {
                    MessageBox.Show("O CNPJ informado não existe no banco de dados.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Insira o CNPJ da Empresa para excluir.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCnpj.Clear();
            txtNomeEmpresarial.Clear();
            txtNomeFantasia.Clear();
            txtPorte.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCep.Clear();
            txtBairro.Clear();
            txtMunicipio.Clear();
            txtUf.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtSituacaoCadastral.Clear();
            txtId.Focus();
        }

    }
}
