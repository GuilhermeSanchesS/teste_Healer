using Healer.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healer.Apresentacao
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
            // usuarioLogado.Text = usuario;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            panel2.Width += 3;
            if(panel2.Width >= 599)
            {
                timer1.Stop();
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }

        private void BemVindo_Load(object sender, EventArgs e)
        {
             Conexao con = new Conexao();
             string usuario = usuarioLogado.Text;
        }
    }
}
