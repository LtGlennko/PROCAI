using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public partial class AgregarPostulante : Form
    {

        private BindingList<Postulante> postulantes;

        public AgregarPostulante(BindingList<Postulante> lstP)
        { 
            InitializeComponent();
            postulantes = lstP;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            char sexo = 'X';
            if (txtSexo.Text.Equals("M")) sexo = 'M';
            else if (txtSexo.Text.Equals("F")) sexo = 'F';

            Postulante p = null;
            Colegio c = new Colegio();
            List<Colegio> lc = new List<Colegio>();
            lc.Add(c);

            p = new Postulante(Convert.ToDateTime("01/01/2018"), 1, 213, null, "5to", 3343241, 12, null);
            postulantes.Add(p);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AgregarPostulante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
