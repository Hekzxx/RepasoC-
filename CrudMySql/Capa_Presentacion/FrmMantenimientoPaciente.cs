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
    public partial class FrmMantenimientoPaciente : Form
    {
        sPaciente objpaciendte = new sPaciente();
        Paciente oPaciente = null;
        
        public FrmMantenimientoPaciente()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtdni.Text = "";
            txtnombre.Text = "";
            txtfecha.Text = "";
            cmbsexo.Text = "";
            txtcelular.Text = "";
            txtdireccion.Text = "";
            txtdistrito.Text = "";

            dataGridView1.DataSource = objpaciendte.Listar_Pacientes();
        }

        private void FrmMantenimientoPaciente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objpaciendte.Listar_Pacientes();
        }

        private string Mantenimiento(string accion)
        {
            oPaciente = new Paciente();
            oPaciente.DNI = txtdni.Text;
            oPaciente.Nombre_completo = txtnombre.Text;
            oPaciente.Fecha_de_nacimiento = Convert.ToInt32(txtfecha.Text);
            oPaciente.Sexo = cmbsexo.Text;
            oPaciente.Numero_de_celular = txtcelular.Text;
            oPaciente.Direccion = txtdireccion.Text;
            oPaciente.Distrito = txtdistrito.Text;

            return objpaciendte.MantenimientoPacientes(oPaciente, accion);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text !="" && txtnombre.Text != "" && txtfecha.Text != "" && cmbsexo.Text != "" && txtcelular.Text != "" && txtdireccion.Text !="" && txtdistrito.Text !="")
            {
                string mensaje = Mantenimiento("1");
                MessageBox.Show(mensaje);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Oh que fue!!!!\n\nHay campos sin rellenar");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text != "" && txtnombre.Text != "" && txtfecha.Text != "" && cmbsexo.Text != "" && txtcelular.Text != "" && txtdireccion.Text != "" && txtdistrito.Text != "")
            {
                string mensaje = Mantenimiento("2");
                MessageBox.Show(mensaje);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Oh que fue!!!!\n\nHay campos sin rellenar");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text != "" && txtnombre.Text != "" && txtfecha.Text != "" && cmbsexo.Text != "" && txtcelular.Text != "" && txtdireccion.Text != "" && txtdistrito.Text != "")
            {
                string mensaje = Mantenimiento("3");
                MessageBox.Show(mensaje);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Oh que fue!!!!\n\nHay campos sin rellenar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                txtdni.Text = dataGridView1.Rows[index].Cells["DNI"].Value.ToString();
                txtnombre.Text = dataGridView1.Rows[index].Cells["Nombre_completo"].Value.ToString();
                txtfecha.Text = dataGridView1.Rows[index].Cells["Fecha_de_nacimiento"].Value.ToString();
                cmbsexo.Text = dataGridView1.Rows[index].Cells["Sexo"].Value.ToString();
                txtcelular.Text = dataGridView1.Rows[index].Cells["Numero_de_celular"].Value.ToString();
                txtdireccion.Text = dataGridView1.Rows[index].Cells["Direccion"].Value.ToString();
                txtdistrito.Text = dataGridView1.Rows[index].Cells["Distrito"].Value.ToString();
            }
        }
    }
}
