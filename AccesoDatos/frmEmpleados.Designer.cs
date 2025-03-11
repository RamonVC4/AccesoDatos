namespace AccesoDatos
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmpleados = new DataGridView();
            butInsertar = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            tablaEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(12, 66);
            dgvEmpleados.Margin = new Padding(3, 4, 3, 4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1046, 509);
            dgvEmpleados.TabIndex = 1;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // butInsertar
            // 
            butInsertar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butInsertar.Location = new Point(407, 599);
            butInsertar.Margin = new Padding(3, 4, 3, 4);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(279, 45);
            butInsertar.TabIndex = 2;
            butInsertar.Text = "Insertar";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, tablaEmpleadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 46);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            menuToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 64);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(107, 42);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // tablaEmpleadosToolStripMenuItem
            // 
            tablaEmpleadosToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            tablaEmpleadosToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 64);
            tablaEmpleadosToolStripMenuItem.Name = "tablaEmpleadosToolStripMenuItem";
            tablaEmpleadosToolStripMenuItem.Size = new Size(258, 42);
            tablaEmpleadosToolStripMenuItem.Text = "Tabla: Empleados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 10);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(12, 582);
            panel2.Name = "panel2";
            panel2.Size = new Size(1047, 10);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_03_04_141134;
            pictureBox1.Location = new Point(1014, 598);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 649);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(butInsertar);
            Controls.Add(dgvEmpleados);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmEmpleados";
            Text = "Empleados";
            Activated += frmEmpleados_Activated;
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button butInsertar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem tablaEmpleadosToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}