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
    public partial class frmInsertarTitulos : Form
    {
        public frmInsertarTitulos()
        {
            InitializeComponent();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string año = dtpPubDate.Value.Year.ToString();
                string mes = dtpPubDate.Value.Month.ToString();
                string dia = dtpPubDate.Value.Day.ToString();
                string fecha = mes + "/" + dia + "/" + año;

                Datos datos = new Datos();
                bool f = datos.comando("insert into titles values ('" + txtID.Text + "','" +
                                                                       txtTitulo.Text.Replace("'", "''") + "','" +
                                                                       txtTipo.Text + "','" +
                                                                       txtPub_ID.Text + "','" +
                                                                       double.Parse(txtPrecio.Text) + "','" +
                                                                       double.Parse(txtAdvance.Text) + "'," +
                                                                       int.Parse(txtRoyalty.Text) + "," +
                                                                       int.Parse(txtYtd_Sales.Text) + ",'" +
                                                                       txtNotas.Text.Replace("'", "''") + "','" +
                                                                       fecha + "')");

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

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTitulos titulos = new frmTitulos();
            titulos.Show();
        }

        private void frmInsertarTitulos_Load(object sender, EventArgs e)
        {

        }
    }
}
