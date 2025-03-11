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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("SELECT " +
                "\r\n    e.emp_id AS ID, " +
                "\r\n    e.fname AS [First Name], " +
                "\r\n    e.minit AS Minit, " +
                "\r\n    e.lname AS [Last Name], " +
                "\r\n    j.job_desc AS [Job Description], " +
                "\r\n    e.job_lvl AS [Job Level], " +
                "\r\n    p.pub_name AS [PUB Name], " +
                "\r\n    e.hire_date AS [Hire Date]" +
                "\r\nFROM " +
                "\r\n    employee e" +
                "\r\nJOIN " +
                "\r\n    jobs j ON j.job_id = e.job_id" +
                "\r\nJOIN " +
                "\r\n    publishers p ON p.pub_id = e.pub_id");
            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarEmpleados insertar = new frmInsertarEmpleados();
            insertar.Show();
            this.Close();
        }

        private void frmEmpleados_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("SELECT * For employee");

            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaEmpleados actualiza = new frmActualizaEmpleados(dgvEmpleados[0, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[1, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[2, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[3, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[4, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[5, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[6, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[7, e.RowIndex].Value.ToString());

            actualiza.Show();
            ActualizaGrid();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
