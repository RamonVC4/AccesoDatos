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
    public partial class frmInsertarAuthors : Form
    {
        public frmInsertarAuthors()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                Datos datos = new Datos();
                bool f = datos.comando("insert into titles values ('" + txtID.Text + "','" +
                                                                       txtFistName.Text + "','" +
                                                                       txtSecondName.Text + "','" +
                                                                       int.Parse(txtPhone.Text) + "','" +
                                                                       txtAddress.Text + "','" +
                                                                       txtCITY.Text + "'," +
                                                                       txtState.Text + "," +
                                                                       int.Parse(txtZIPCode.Text) + "')");

                if (f == true)
                {
                    MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmTitulos titulos = new frmTitulos();
                    titulos.Show();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTitulos titulos = new frmTitulos();
            titulos.Show();
        }
    }
}
