namespace AccesoDatos
{
    partial class frmActualizaEmpleados
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
            butEliminar = new Button();
            butActualizar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            dtpPubDate = new DateTimePicker();
            comboBoxJob = new ComboBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            txtJob_lvl = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtLName = new TextBox();
            label6 = new Label();
            txtFName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMinit = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butEliminar
            // 
            butEliminar.Font = new Font("Segoe UI", 13.8F);
            butEliminar.Location = new Point(232, 316);
            butEliminar.Margin = new Padding(3, 4, 3, 4);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(116, 39);
            butEliminar.TabIndex = 65;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // butActualizar
            // 
            butActualizar.Font = new Font("Segoe UI", 13.8F);
            butActualizar.Location = new Point(354, 316);
            butActualizar.Margin = new Padding(3, 4, 3, 4);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(116, 39);
            butActualizar.TabIndex = 63;
            butActualizar.Text = "Actualizar";
            butActualizar.UseVisualStyleBackColor = true;
            butActualizar.Click += butActualizar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(21, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 10);
            panel1.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(199, 9);
            label4.Name = "label4";
            label4.Size = new Size(230, 38);
            label4.TabIndex = 66;
            label4.Text = "Tabla: Employee";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(21, 299);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 10);
            panel2.TabIndex = 68;
            // 
            // dtpPubDate
            // 
            dtpPubDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPubDate.Location = new Point(354, 258);
            dtpPubDate.Name = "dtpPubDate";
            dtpPubDate.Size = new Size(263, 34);
            dtpPubDate.TabIndex = 121;
            // 
            // comboBoxJob
            // 
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Items.AddRange(new object[] { "New Hire - Job not specified", "Chief Executive Officer", "Business Operations Manager", "Chief Financial Officier", "Publisher", "Managing Editor", "Marketing Manager", "Public Relations Manager", "Acquisitions Manager", "Productions Manager", "Operations Manager", "Editor", "Sales Representative", "Designer" });
            comboBoxJob.Location = new Point(54, 187);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(276, 28);
            comboBoxJob.TabIndex = 120;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "New Moon Books", "Binnet & Hardley", "Algodata Infosystems", "Five Lakes Publishing", "Ramona Publishers", "GGG&G", "Scootney Books", "Lucerne Publishing" });
            comboBox1.Location = new Point(56, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(274, 28);
            comboBox1.TabIndex = 119;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_03_04_141134;
            pictureBox1.Location = new Point(587, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 118;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(354, 223);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 117;
            label10.Text = "Hire_date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(354, 153);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 116;
            label9.Text = "Job_lvl";
            // 
            // txtJob_lvl
            // 
            txtJob_lvl.Font = new Font("Segoe UI", 12F);
            txtJob_lvl.Location = new Point(354, 185);
            txtJob_lvl.Margin = new Padding(3, 4, 3, 4);
            txtJob_lvl.Name = "txtJob_lvl";
            txtJob_lvl.Size = new Size(138, 34);
            txtJob_lvl.TabIndex = 115;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(54, 149);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 114;
            label8.Text = "Job_ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(354, 75);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 113;
            label7.Text = "LName";
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Segoe UI", 12F);
            txtLName.Location = new Point(354, 107);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.MaxLength = 12;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(153, 34);
            txtLName.TabIndex = 112;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(192, 75);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 111;
            label6.Text = "FName";
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Segoe UI", 12F);
            txtFName.Location = new Point(192, 107);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(138, 34);
            txtFName.TabIndex = 110;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(54, 223);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 109;
            label3.Text = "Pub_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(503, 153);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 108;
            label2.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.Font = new Font("Segoe UI", 12F);
            txtMinit.Location = new Point(503, 185);
            txtMinit.Margin = new Padding(3, 4, 3, 4);
            txtMinit.MaxLength = 1;
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(34, 34);
            txtMinit.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(54, 75);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 106;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(54, 107);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.MaxLength = 9;
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 34);
            txtID.TabIndex = 105;
            // 
            // frmActualizaEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 383);
            Controls.Add(dtpPubDate);
            Controls.Add(comboBoxJob);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtJob_lvl);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtLName);
            Controls.Add(label6);
            Controls.Add(txtFName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMinit);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(butEliminar);
            Controls.Add(butActualizar);
            Name = "frmActualizaEmpleados";
            Text = "Empleados";
            Load += frmActualizaEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butEliminar;
        private Button butActualizar;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private DateTimePicker dtpPubDate;
        private ComboBox comboBoxJob;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label9;
        private TextBox txtJob_lvl;
        private Label label8;
        private Label label7;
        private TextBox txtLName;
        private Label label6;
        private TextBox txtFName;
        private Label label3;
        private Label label2;
        private TextBox txtMinit;
        private Label label1;
        private TextBox txtID;
    }
}