using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InicioExterno : Form
    {
        public InicioExterno()
        {
            InitializeComponent();
        }

        private void btnSugerir_Click(object sender, EventArgs e)
        {
            SolicitarColegio sc = new SolicitarColegio();
            this.Dispose();
            sc.StartPosition = FormStartPosition.CenterScreen;
            if (sc.ShowDialog() == DialogResult.OK)
            {

            }
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            InformacionParaExterno IE = new InformacionParaExterno();
            IE.SetDesktopLocation(100, 100);
            this.Visible = false;
            IE.StartPosition = FormStartPosition.CenterScreen;
            if (IE.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }
    }
}
