namespace AccesoDatos
{
    partial class frmTitulos
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
            butInsertar = new Button();
            dgvTitulos = new DataGridView();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            tablaTitlesToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butInsertar
            // 
            butInsertar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butInsertar.Location = new Point(536, 570);
            butInsertar.Margin = new Padding(3, 4, 3, 4);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(245, 47);
            butInsertar.TabIndex = 2;
            butInsertar.Text = "Insertar";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // dgvTitulos
            // 
            dgvTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitulos.Location = new Point(7, 63);
            dgvTitulos.Margin = new Padding(3, 4, 3, 4);
            dgvTitulos.Name = "dgvTitulos";
            dgvTitulos.RowHeadersWidth = 51;
            dgvTitulos.Size = new Size(1241, 483);
            dgvTitulos.TabIndex = 3;
            dgvTitulos.CellContentClick += dgvTitulos_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(7, 553);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 10);
            panel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, tablaTitlesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1260, 46);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
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
            // tablaTitlesToolStripMenuItem
            // 
            tablaTitlesToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            tablaTitlesToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 64);
            tablaTitlesToolStripMenuItem.Name = "tablaTitlesToolStripMenuItem";
            tablaTitlesToolStripMenuItem.Size = new Size(186, 42);
            tablaTitlesToolStripMenuItem.Text = "Tabla: Titles";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(7, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(1242, 10);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_03_04_141134;
            pictureBox1.Location = new Point(1203, 575);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // frmTitulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 638);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvTitulos);
            Controls.Add(butInsertar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTitulos";
            Text = "Titulos";
            Activated += frmTitulos_Activated;
            Load += frmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button butInsertar;
        public DataGridView dgvTitulos;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem tablaTitlesToolStripMenuItem;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}