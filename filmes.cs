using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace proj_14._6
{
    public partial class filmes : UserControl
    {
        public filmes()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source=DESKTOP-0FRG50R;Inicitial Catalog=cineproxy;Integrated Security=True");
            string sql = "INSERT INTO dbo.filme(id,titulo,duracao.lancamento,genero,classificacao,imagem,sinopse)" +
                " VALUES (@id,@titulo,@duracao,@lancamento,@genero,@classificacao,@imagem,@sinopse)";
            Random numeroId = new Random();
            numeroId.Next();

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);

                c.Parameters.Add(new SqlParameter("@id", numeroId.Next()));
                c.Parameters.Add(new SqlParameter("@titulo", this.boxtitulo.Text));
                c.Parameters.Add(new SqlParameter("@duracao", this.boxduraçao.Text));
                c.Parameters.Add(new SqlParameter("@lancamento", this.boxlançamento.Text));
                c.Parameters.Add(new SqlParameter("@genero", this.boxgenero.Text));
                c.Parameters.Add(new SqlParameter("@classificacao", this.boxclassificaçao.Text));
                c.Parameters.Add(new SqlParameter("@imagem", this.boximagem.Text));
                c.Parameters.Add(new SqlParameter("@sinopse", this.boxsinopse.Text));

                conn.Open();

                c.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Enviados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }

     

            
        }

        private void boxtitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
