using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsular
{
    public partial class frmCalcular : Form
    {
        public frmCalcular()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cl_Calculo Calculo = new cl_Calculo();

            double preco_inicial = double.Parse(txtValor.Text);

            int tipo_Produto = 0;

            if (rbtLeite.Checked)
                tipo_Produto = 1;

            else if (rbtMartelo.Checked)
                tipo_Produto = 2;

            else if (rbtProtetor.Checked)
                tipo_Produto = 3;

            else if (rdbFeijao.Checked)
                tipo_Produto = 4;

            else if (rdbFuradeira.Checked)
                tipo_Produto = 5;

            double resultado = Calculo.CalculaPrecoFinal(preco_inicial, tipo_Produto);

            lblResultado.Text = resultado.ToString();
        }
    }
}
