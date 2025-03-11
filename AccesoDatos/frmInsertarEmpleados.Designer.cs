namespace AccesoDatos
{
    partial class frmInsertarEmpleados
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
            panel2 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
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
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            comboBoxJob = new ComboBox();
            dtpPubDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butInsertar
            // 
            butInsertar.Font = new Font("Segoe UI", 13.8F);
            butInsertar.Location = new Point(220, 307);
            butInsertar.Margin = new Padding(3, 4, 3, 4);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(200, 38);
            butInsertar.TabIndex = 80;
            butInsertar.Text = "Insertar";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(12, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(627, 10);
            panel2.TabIndex = 100;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 10);
            panel1.TabIndex = 99;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(206, 0);
            label4.Name = "label4";
            label4.Size = new Size(230, 38);
            label4.TabIndex = 98;
            label4.Text = "Tabla: Employee";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(368, 215);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 96;
            label10.Text = "Hire_date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(368, 145);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 95;
            label9.Text = "Job_lvl";
            // 
            // txtJob_lvl
            // 
            txtJob_lvl.Font = new Font("Segoe UI", 12F);
            txtJob_lvl.Location = new Point(368, 177);
            txtJob_lvl.Margin = new Padding(3, 4, 3, 4);
            txtJob_lvl.Name = "txtJob_lvl";
            txtJob_lvl.Size = new Size(138, 34);
            txtJob_lvl.TabIndex = 94;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(68, 141);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 93;
            label8.Text = "Job_ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(368, 67);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 91;
            label7.Text = "LName";
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Segoe UI", 12F);
            txtLName.Location = new Point(368, 99);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.MaxLength = 12;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(153, 34);
            txtLName.TabIndex = 90;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(206, 67);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 89;
            label6.Text = "FName";
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Segoe UI", 12F);
            txtFName.Location = new Point(206, 99);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(138, 34);
            txtFName.TabIndex = 88;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(68, 215);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 87;
            label3.Text = "Pub_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(517, 145);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 85;
            label2.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.Font = new Font("Segoe UI", 12F);
            txtMinit.Location = new Point(517, 177);
            txtMinit.Margin = new Padding(3, 4, 3, 4);
            txtMinit.MaxLength = 1;
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(34, 34);
            txtMinit.TabIndex = 84;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(68, 67);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 83;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(68, 99);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.MaxLength = 9;
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 34);
            txtID.TabIndex = 82;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_03_04_141134;
            pictureBox1.Location = new Point(601, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 101;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "New Moon Books", "Binnet & Hardley", "Algodata Infosystems", "Five Lakes Publishing", "Ramona Publishers", "GGG&G", "Scootney Books", "Lucerne Publishing" });
            comboBox1.Location = new Point(70, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(274, 28);
            comboBox1.TabIndex = 102;
            // 
            // comboBoxJob
            // 
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Items.AddRange(new object[] { "New Hire - Job not specified", "Chief Executive Officer", "Business Operations Manager", "Chief Financial Officier", "Publisher", "Managing Editor", "Marketing Manager", "Public Relations Manager", "Acquisitions Manager", "Productions Manager", "Operations Manager", "Editor", "Sales Representative", "Designer" });
            comboBoxJob.Location = new Point(68, 179);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(276, 28);
            comboBoxJob.TabIndex = 103;
            // 
            // dtpPubDate
            // 
            dtpPubDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPubDate.Location = new Point(368, 250);
            dtpPubDate.Name = "dtpPubDate";
            dtpPubDate.Size = new Size(263, 34);
            dtpPubDate.TabIndex = 104;
            dtpPubDate.ValueChanged += dtpPubDate_ValueChanged;
            // 
            // frmInsertarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 374);
            Controls.Add(dtpPubDate);
            Controls.Add(comboBoxJob);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
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
            Controls.Add(butInsertar);
            Name = "frmInsertarEmpleados";
            Text = "Insertar Empleados";
            Load += frmInsertarEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button butInsertar;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
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
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private ComboBox comboBoxJob;
        private DateTimePicker dtpPubDate;
    }
}