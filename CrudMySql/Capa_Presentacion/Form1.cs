using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Services;
using Capa_Entidades;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {
        sPaciente objpaciente = new sPaciente();
        Paciente oPaciente = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
           if (txtusuario.Text != "" && txtcontrasenia.Text != "")
            {
                int validar;
                int admin;

                oPaciente = new Paciente();
                oPaciente.DNI = Convert.ToString(txtusuario.Text);
                oPaciente.Numero_de_celular = Convert.ToString(txtcontrasenia.Text);

                validar = objpaciente.ValidacionPaciente(oPaciente);

                if (validar==1)
                {
                    admin = objpaciente.ValidacionAdmin(oPaciente);

                    if (admin==1)
                    {
                        MessageBox.Show("Sesion iniciada del paciente correctamente");
                        FrmMantenimientoPaciente f = new FrmMantenimientoPaciente();
                        f.ShowDialog();
                    }
                }
                
            }
        }
    }
}
