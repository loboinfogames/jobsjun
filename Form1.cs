using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_14._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btBombom_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            bomboniere vaibombom =new bomboniere();
            vaibombom.ShowDialog();
            this.Close();*/
        }

        private void btFilmes_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            btfilmes_Click vaifilmes =new filmes();
            vaifilmes.ShowDialog();
            this.Close();*/
        }

        private void btcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            cliente vaicliente = new cliente();
            vaicliente.ShowDialog();
            this.Close();
        }

        private void btFilmes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            filmes vaifilme = new filmes();
            //vaifilme.ShowDialog();
            this.Close();
        }
    }
}
