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
    public partial class frmTitulos : Form
    {
        public frmTitulos()
        {
            InitializeComponent();
        }

        private void frmTitulos_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select * For titles");

            if (ds != null)
            {
                dgvTitulos.DataSource = ds.Tables[0];
            }
        }

        private void dgvTitulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaTitulos actualiza = new frmActualizaTitulos(dgvTitulos[0, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[1, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[2, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[3, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[4, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[5, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[6, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[7, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[8, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[9, e.RowIndex].Value.ToString());

            actualiza.Show();
            this.Close();
        }

        private void frmTitulos_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select title_id as ID,title as [Title], type as [Type], pb.pub_name as [Pub Nombre],price as Price,advance as Advance ,royalty as Royalty,ytd_sales as Sales,notes as Notes,pubdate as PubDate  From Titles t, publishers pb where t.pub_id = pb.pub_id");

            if (ds != null)
            {
                dgvTitulos.DataSource = ds.Tables[0];
            }
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarTitulos Titulos = new frmInsertarTitulos();
            Titulos.Show();
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
