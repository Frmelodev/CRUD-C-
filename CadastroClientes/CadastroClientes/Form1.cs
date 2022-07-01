
using System;
using System.Collections.Generic;
using System.data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using system.Windows.forms;
using System.Data.SqlClient;
namespace CadastroClientes
{
    public partial class Form1 : Form
         
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQl;


        
        public frmCadastroCliente ()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
            
            }
            cathc(Exception){
                throw;
            }
            conexão = new SqlConnection(@"Server=.\sqlexpress;Database=bdcadastrocliente;Trusted_Connection=True;");
            strSQL = "INSERT INTO CAD_CLIENTE (NOME,ENDEREÇO,CEP,BAIRRO,CIDADE,UF,TELEFONE,EMAIL) VALUES (@NOME,@ENDEREÇO,@CEP,@BAIRRO,@CIDADE,@UF,@TELEFONE,@EMAIL)";

            command = new SqlCommand(strSQl, connection);

            command.Parameters.AddWithValue("@NOME", txtNome.Text);
            command.Parameters.AddWithValue("@ENDEREÇO", txtEndereço.Text);
            command.Parameters.AddWithValue("@CEP", txtCEP.Text);
            command.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
            command.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
            command.Parameters.AddWithValue("@UF", txtUF.Text);
            command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);

            connection.Open();
            commando.ExecuteNonQuery();

            connection.Close();
            command.Clone();
        }

        private void Exibir_Click(object sender, EventArgs e)
        {
            try
            {

            }
            cathc(Exception){
                throw;
            }
            conexão = new SqlConnection(@"Server=.\sqlexpress;Database=bdcadastrocliente;Trusted_Connection=True;");
            strSQL = "SELECT * FROM CAD_CLIENTE";

            DataSet ds = new DataSet();
            da = new SqlDataAdapter(strSQl, connection);

            connection.Open();
            da.FIlls(ds);

            dgvDados.DataSource = ds.tables[0];
            

            connection.Close();
            command.Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            cathc(Exception){
                throw;
            }
            conexão = new SqlConnection(@"Server=.\sqlexpress;Database=bdcadastrocliente;Trusted_Connection=True;");
            strSQL = "SELECT * FROM CAD_CLIENTE WHERE ID = @ID";

            command = new SqlCommand(strSQl, connection);

            command.Parameters.AddWithValue("@ID", txtID.Text);
         
            connection.Open();
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtNome.txt = (string) dr["nome"];
                txtEndereço.txt = (string)dr["endereço"];
                txtCep.txt = Convert.ToString(dr["cep"]);
                txtBairro.txt = (string)dr["bairro"];
                txtCidade.txt = (string)dr["cidade"];
                txtUF.txt = (string)dr["UF"];
                txtTelefone.txt = Convert.ToString(dr["telefone"]);
                txtEmail.txt = (string)dr["email"];
            }

            connection.Close();
            command.Clone();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            cathc(Exception){
                throw;
            }
            conexão = new SqlConnection(@"Server=.\sqlexpress;Database=bdcadastrocliente;Trusted_Connection=True;");
            strSQL = "UPDATE CAD_CLIENTE SET NOME = @NOME, ENDEREÇO= @ENDEREÇO,CEP = @CEP,BAIRRO = @BAIRRO,CIDADE = @CIDADE,UF=@UF,TELEFONE= @TELEFONE,EMAIL=@EMAIL  WHERE ID=@ID";

            command = new SqlCommand(strSQl, connection);
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@NOME", txtNome.Text);
            command.Parameters.AddWithValue("@ENDEREÇO", txtEndereço.Text);
            command.Parameters.AddWithValue("@CEP", txtCEP.Text);
            command.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
            command.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
            command.Parameters.AddWithValue("@UF", txtUF.Text);
            command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);

            connection.Open();
            commando.ExecuteNonQuery();

            connection.Close();
            command.Clone();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

            }
            cathc(Exception){
                throw;
            }
            conexão = new SqlConnection(@"Server=.\sqlexpress;Database=bdcadastrocliente;Trusted_Connection=True;");
            strSQL = "DELETE CAD_CLIENTE WHERE ID = @ID";

            command = new SqlCommand(strSQl, connection);

            command.Parameters.AddWithValue("@ID", txtID.Text);
           

            connection.Open();
            commando.ExecuteNonQuery();

            connection.Close();
            command.Clone();
        }
    }
}