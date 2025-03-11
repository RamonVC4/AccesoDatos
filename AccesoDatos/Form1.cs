namespace AccesoDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            bool f = obj.prueba();
            if (f)
            {
                MessageBox.Show("Conexion Exitosa");
            }
            else
            {
                MessageBox.Show("Error de Conexion");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAutors autors = new frmAutors();
            autors.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmpleados Empleados = new frmEmpleados();
            Empleados.Show();
        }

        private void btnTitles_Click(object sender, EventArgs e)
        {
            frmTitulos Titulos = new frmTitulos();
            Titulos.Show();
        }
    }
}
