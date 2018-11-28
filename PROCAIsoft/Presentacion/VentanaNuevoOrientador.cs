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
    public partial class VentanaNuevoOrientador : Form
    {
        public VentanaNuevoOrientador()
        {
            InitializeComponent();
        }

        private void VentanaNuevoOrientador_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Orientador O = new Orientador();
            // = this.textBox_nombre.Text;
            //string mes = txt_mes.Text;
            //string dirigido = txt_dirigido.Text;
            //comprobacion del numero de vacantes para que no se caiga

            try
            {
                int num = Int32.Parse(this.label5.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Número incorrecto", "System", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            //PA.EstaVigente = 1;
            //PA.FechaCreacion = DateTime.Today;




            if (Nombre.Text.Equals("") || label2.Text.Equals("") || label3.Text.Equals("")
                || label4.Text.Equals("") || label5.Text.Equals(""))
            {
                MessageBox.Show("Datos inconsistentes", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
                MessageBox.Show("Registrado", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.ProcesosAdmision.Add(PA);//agrego el proceso a la lista

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Cancelado por usuario!", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
