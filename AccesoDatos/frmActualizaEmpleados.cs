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
    public partial class frmActualizaEmpleados : Form
    {
        public frmActualizaEmpleados(string ID, string fname, string minit,
                                  string lname, string job_ID, string job_lvl,
                                  string pub_ID, string hire_date)
        {
            InitializeComponent();
            txtID.Text = ID;
            txtFName.Text = fname;
            txtLName.Text = lname;
            txtMinit.Text = minit;
            comboBoxJob.Text = job_ID;
            txtJob_lvl.Text = job_lvl;
            comboBox1.Text = pub_ID;
            dtpPubDate.Text = hire_date;
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from employee where emp_id = '" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmEmpleados empleados = new frmEmpleados();
                    empleados.Show();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string dia = dtpPubDate.Value.Day.ToString();
                string mes = dtpPubDate.Value.Month.ToString();
                string año = dtpPubDate.Value.Year.ToString();
                string fecha = mes + "/" + dia + "/" + año;

                Datos datos = new Datos();
                bool f = datos.comando("update employee set " +
                                       "fname = '" + txtFName.Text.Replace("'", "''") +
                                       "', minit = '" + txtMinit.Text +
                                       "', lname = '" + txtLName.Text.Replace("'", "''") +
                                       "(SELECT DISTINCT j.job_id " +
                                       " FROM jobs AS j " +
                                       " WHERE j.job_desc = '" + 
                                       comboBoxJob.Text.Replace("'", "''") + "')," +
                                       ", job_lvl = " + int.Parse(txtJob_lvl.Text) +
                                       "(SELECT DISTINCT p.pub_id " +
                                       " FROM publishers AS p " +
                                       " WHERE p.pub_name = '" + 
                                       comboBox1.Text.Replace("'", "''") + "')," +
                                       "', hire_date = '" + fecha +
                                       "' where emp_id = '" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmEmpleados empleados = new frmEmpleados();
                    empleados.Show();
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Alguno de los datos en inconsistente, favor de revisar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
        }

        private void frmActualizaEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
