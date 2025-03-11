namespace AccesoDatos
{
    partial class frmInsertarAuthors
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
            btnInsertar = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            chkContract = new CheckBox();
            txtZIPCode = new TextBox();
            label9 = new Label();
            txtState = new TextBox();
            label8 = new Label();
            txtCITY = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtSecondName = new TextBox();
            label3 = new Label();
            txtFistName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Font = new Font("Segoe UI", 13.8F);
            btnInsertar.Location = new Point(261, 386);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 41);
            btnInsertar.TabIndex = 41;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(19, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 10);
            panel2.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(19, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 10);
            panel1.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(197, 9);
            label6.Name = "label6";
            label6.Size = new Size(207, 38);
            label6.TabIndex = 59;
            label6.Text = "Tabla: Authors";
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Font = new Font("Segoe UI", 12F);
            chkContract.Location = new Point(77, 327);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(109, 32);
            chkContract.TabIndex = 58;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // txtZIPCode
            // 
            txtZIPCode.Font = new Font("Segoe UI", 12F);
            txtZIPCode.Location = new Point(448, 280);
            txtZIPCode.Name = "txtZIPCode";
            txtZIPCode.Size = new Size(164, 34);
            txtZIPCode.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(445, 257);
            label9.Name = "label9";
            label9.Size = new Size(90, 28);
            label9.TabIndex = 56;
            label9.Text = "ZIP Code";
            // 
            // txtState
            // 
            txtState.Font = new Font("Segoe UI", 12F);
            txtState.Location = new Point(261, 280);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(164, 34);
            txtState.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(261, 257);
            label8.Name = "label8";
            label8.Size = new Size(56, 28);
            label8.TabIndex = 54;
            label8.Text = "State";
            // 
            // txtCITY
            // 
            txtCITY.Font = new Font("Segoe UI", 12F);
            txtCITY.Location = new Point(77, 280);
            txtCITY.Name = "txtCITY";
            txtCITY.Size = new Size(164, 34);
            txtCITY.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(77, 257);
            label7.Name = "label7";
            label7.Size = new Size(46, 28);
            label7.TabIndex = 52;
            label7.Text = "City";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(261, 216);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(351, 34);
            txtAddress.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(261, 193);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 50;
            label5.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(77, 216);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 34);
            txtPhone.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(77, 193);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 48;
            label4.Text = "Phone";
            // 
            // txtSecondName
            // 
            txtSecondName.Font = new Font("Segoe UI", 12F);
            txtSecondName.Location = new Point(355, 150);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(257, 34);
            txtSecondName.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(355, 127);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 46;
            label3.Text = "Second Name";
            // 
            // txtFistName
            // 
            txtFistName.Font = new Font("Segoe UI", 12F);
            txtFistName.Location = new Point(77, 150);
            txtFistName.Name = "txtFistName";
            txtFistName.Size = new Size(252, 34);
            txtFistName.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(77, 127);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 44;
            label2.Text = "Fist Name";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(77, 88);
            txtID.MaxLength = 11;
            txtID.Name = "txtID";
            txtID.Size = new Size(164, 34);
            txtID.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(77, 65);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 42;
            label1.Text = "ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_03_04_141134;
            pictureBox1.Location = new Point(593, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // frmInsertarAuthors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 434);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(chkContract);
            Controls.Add(txtZIPCode);
            Controls.Add(label9);
            Controls.Add(txtState);
            Controls.Add(label8);
            Controls.Add(txtCITY);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtSecondName);
            Controls.Add(label3);
            Controls.Add(txtFistName);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnInsertar);
            Name = "frmInsertarAuthors";
            Text = "Insertar Autores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInsertar;
        private Panel panel2;
        private Panel panel1;
        private Label label6;
        private CheckBox chkContract;
        private TextBox txtZIPCode;
        private Label label9;
        private TextBox txtState;
        private Label label8;
        private TextBox txtCITY;
        private Label label7;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtSecondName;
        private Label label3;
        private TextBox txtFistName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private PictureBox pictureBox1;
    }
}