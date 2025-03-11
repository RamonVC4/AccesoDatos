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
            DataSet ds = obj.consulta("Select au_id as [Authors ID], au_lname as [Last Name]," +
                " au_FName as [Fist Name], phone as Phone, address as Address, city as City," +
                " state as State, zip as Zip, contract as Constract from authors");

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
            frmInsertarAuthors autors = new frmInsertarAuthors();
            autors.Show();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
