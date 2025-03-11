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
    public partial class frmActualizaAutor : Form
    {
        public frmActualizaAutor(string id, string fname, string lname, string phone,
            string address, string city, string state, string zip, bool contract)
        {
            InitializeComponent();
            txtFistName.Text = fname;
            txtSecondName.Text = lname;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtCITY.Text = city;
            txtState.Text = state;
            txtZIPCode.Text = zip;
            txtID.Text = id;
            chkContract.Checked = contract;
        }

        private void frmActualizaAutor_Load(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update authors set " +
                "au_fname='" + txtFistName.Text +
                "', au_lname='" + txtSecondName.Text +
                "', phone='" + txtPhone.Text +
                "', address='" + txtAddress.Text +
                "', city='" + txtCITY.Text +
                "', state='" + txtState.Text +
                "', zip='" + txtZIPCode.Text +
                "', contract=" + (chkContract.Checked ? 1 : 0) +
                " where au_id='" + txtID.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al Actualizar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar el registro?",
                "Sistma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from authors where au_id='" + txtID.Text + "'");
                if (f == true)
                {
                    MessageBox.Show("Datos eliminados", "Sistema"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
