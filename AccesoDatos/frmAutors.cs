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
    public partial class frmAutors : Form
    {
        public frmAutors()
        {
            InitializeComponent();
        }

        private void frmAutors_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select * from authors");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaAutor actualiza = new frmActualizaAutor(
                dgvAuthors[0, e.RowIndex].Value.ToString(),
                dgvAuthors[1, e.RowIndex].Value.ToString(),
                dgvAuthors[2, e.RowIndex].Value.ToString(),
                dgvAuthors[3, e.RowIndex].Value.ToString(),
                dgvAuthors[4, e.RowIndex].Value.ToString(),
                dgvAuthors[5, e.RowIndex].Value.ToString(),
                dgvAuthors[6, e.RowIndex].Value.ToString(),
                dgvAuthors[7, e.RowIndex].Value.ToString(),
                Convert.ToBoolean(dgvAuthors[8, e.RowIndex].Value));

            actualiza.Show();
            ActualizaGrid();
        }

        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Selext * from authors");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }
        }

        private void frmAutors_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
