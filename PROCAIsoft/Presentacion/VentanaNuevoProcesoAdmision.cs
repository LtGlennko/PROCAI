using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
namespace Presentacion
{
    public partial class VentanaNuevoProcesoAdmision : Form
    {
        public BindingList<ProcesoAdmision> ProcesosAdmision;
        public VentanaNuevoProcesoAdmision()
        {
            InitializeComponent();
            ProcesosAdmision = new BindingList<ProcesoAdmision>();
        }

        private void VentanaNuevoProcesoAdmision_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ProcesoAdmision PA = new ProcesoAdmision();
            PA.Descripcion= this.textBox_nombre.Text;
            string mes=txt_mes.Text;
            string dirigido= txt_dirigido.Text;
            //comprobacion del numero de vacantes para que no se caiga

            try{
                PA.CantidadVacantes = Int32.Parse(this.textBox_Vacantes.Text);
            }
            catch (Exception) {
                MessageBox.Show("Wrong number bitch!", "System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
            PA.EstaVigente = 1;
            PA.FechaCreacion = DateTime.Today;

            

            
            if (PA.Descripcion.Equals("") || PA.CantidadVacantes<0  ) {
                MessageBox.Show("Datos inconsistentes", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                this.Close();
                MessageBox.Show("Registrado","System",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.ProcesosAdmision.Add(PA);//agrego el proceso a la lista

            }
            this.textBox_nombre.Text = "";
            this.textBox_Vacantes.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void VentanaNuevoProcesoAdmision_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Cancelado por usuario!", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
