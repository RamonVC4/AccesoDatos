using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class frmInsertarEmpleados : Form
    {
        public frmInsertarEmpleados()
        {
            InitializeComponent();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string dia = dtpPubDate.Value.Day.ToString();
                string mes = dtpPubDate.Value.Month.ToString();
                string año = dtpPubDate.Value.Year.ToString();
                string fecha = mes + "/" + dia + "/" + año;

                Datos datos = new Datos();
                   bool f = datos.comando("INSERT INTO employee  VALUES (" +
                   "'" + txtID.Text + "'," +
                   "'" + txtFName.Text.Replace("'", "''") + "'," +
                   "'" + txtMinit.Text + "'," +
                   "'" + txtLName.Text.Replace("'", "''") + "'," +
                   "(SELECT DISTINCT j.job_id " +
                   " FROM jobs AS j " +
                   " WHERE j.job_desc = '" + comboBoxJob.Text.Replace("'", "''") + "')," + 
                   int.Parse(txtJob_lvl.Text) + "," +
                   "(SELECT DISTINCT p.pub_id " +
                   " FROM publishers AS p " +
                   " WHERE p.pub_name = '" + comboBox1.Text.Replace("'", "''") + "')," +
                   "'" + fecha + "')");

                if (f == true)
                {
                    MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmEmpleados empleados = new frmEmpleados();
                    empleados.Show();
                }
                else
                {
                    MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error al insertar. Favor de verificar los tipos de datos ingresados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
        }

        private void frmInsertarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void dtpPubDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
