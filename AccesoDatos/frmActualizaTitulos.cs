﻿using System;
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
    public partial class frmActualizaTitulos : Form
    {
        public frmActualizaTitulos(string ID, string titulo, string tipo,
                                string pub_ID, string precio, string advance,
                                string royalty, string ytd_sales, string notas, string pubdate)
        {
            InitializeComponent();
            txtID.Text = ID;
            txtTitulo.Text = titulo;
            txtTipo.Text = tipo;
            txtPub_ID.Text = pub_ID;
            txtPrecio.Text = precio;
            txtAdvance.Text = advance;
            txtRoyalty.Text = royalty;
            txtYtd_Sales.Text = ytd_sales;
            dtpPubDate.Text = pubdate;
            txtNotas.Text = notas;
        }

        private void frmActualizaTitulos_Load(object sender, EventArgs e)
        {

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from titles where title_id = '" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmTitulos titulos = new frmTitulos();
                    titulos.Show();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string dia = dtpPubDate.Value.Day.ToString();  
                string mes = dtpPubDate.Value.Month.ToString();
                string año = dtpPubDate.Value.Year.ToString();
                string fecha = mes + "/" + dia + "/" + año;

                Datos datos = new Datos();
                bool f = datos.comando("update titles set " +
                                       "title = '" + txtTitulo.Text.Replace("'", "''") +
                                       "', type = '" + txtTipo.Text +
                                       "', pub_id = '" + txtPub_ID.Text +
                                       "', price = '" + double.Parse(txtPrecio.Text) +
                                       "', advance = '" + double.Parse(txtAdvance.Text) +
                                       "', royalty = " + int.Parse(txtRoyalty.Text) +
                                       ", ytd_sales = " + int.Parse(txtYtd_Sales.Text) +
                                       ", notes = '" + txtNotas.Text.Replace("'", "''") +
                                       "', pubdate = '" + fecha +
                                       "' where title_id = '" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmTitulos titulos = new frmTitulos();
                    titulos.Show();
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
            frmTitulos titulos = new frmTitulos();
            titulos.Show();
        }
    }
}
