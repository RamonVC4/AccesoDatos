﻿namespace AccesoDatos
{
    partial class frmActualizaAutor
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
            btnActualizar = new Button();
            btnBorrar = new Button();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 13.8F);
            btnActualizar.Location = new Point(218, 381);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 39);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 13.8F);
            btnBorrar.Location = new Point(363, 381);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(139, 39);
            btnBorrar.TabIndex = 21;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_03_04_141134;
            pictureBox1.Location = new Point(586, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(12, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 10);
            panel2.TabIndex = 82;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(12, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 10);
            panel1.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(190, 4);
            label6.Name = "label6";
            label6.Size = new Size(207, 38);
            label6.TabIndex = 80;
            label6.Text = "Tabla: Authors";
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Font = new Font("Segoe UI", 12F);
            chkContract.Location = new Point(70, 322);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(109, 32);
            chkContract.TabIndex = 79;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // txtZIPCode
            // 
            txtZIPCode.Font = new Font("Segoe UI", 12F);
            txtZIPCode.Location = new Point(441, 275);
            txtZIPCode.Name = "txtZIPCode";
            txtZIPCode.Size = new Size(164, 34);
            txtZIPCode.TabIndex = 78;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(438, 252);
            label9.Name = "label9";
            label9.Size = new Size(90, 28);
            label9.TabIndex = 77;
            label9.Text = "ZIP Code";
            // 
            // txtState
            // 
            txtState.Font = new Font("Segoe UI", 12F);
            txtState.Location = new Point(254, 275);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(164, 34);
            txtState.TabIndex = 76;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(254, 252);
            label8.Name = "label8";
            label8.Size = new Size(56, 28);
            label8.TabIndex = 75;
            label8.Text = "State";
            // 
            // txtCITY
            // 
            txtCITY.Font = new Font("Segoe UI", 12F);
            txtCITY.Location = new Point(70, 275);
            txtCITY.Name = "txtCITY";
            txtCITY.Size = new Size(164, 34);
            txtCITY.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(70, 252);
            label7.Name = "label7";
            label7.Size = new Size(46, 28);
            label7.TabIndex = 73;
            label7.Text = "City";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(254, 211);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(351, 34);
            txtAddress.TabIndex = 72;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(254, 188);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 71;
            label5.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(70, 211);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 34);
            txtPhone.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(70, 188);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 69;
            label4.Text = "Phone";
            // 
            // txtSecondName
            // 
            txtSecondName.Font = new Font("Segoe UI", 12F);
            txtSecondName.Location = new Point(348, 145);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(257, 34);
            txtSecondName.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(348, 122);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 67;
            label3.Text = "Second Name";
            // 
            // txtFistName
            // 
            txtFistName.Font = new Font("Segoe UI", 12F);
            txtFistName.Location = new Point(70, 145);
            txtFistName.Name = "txtFistName";
            txtFistName.Size = new Size(252, 34);
            txtFistName.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(70, 122);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 65;
            label2.Text = "Fist Name";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(70, 83);
            txtID.MaxLength = 11;
            txtID.Name = "txtID";
            txtID.Size = new Size(164, 34);
            txtID.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(70, 60);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 63;
            label1.Text = "ID";
            // 
            // frmActualizaAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 455);
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
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Name = "frmActualizaAutor";
            Text = "Authors";
            Load += frmActualizaAutor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnActualizar;
        private Button btnBorrar;
        private PictureBox pictureBox1;
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
    }
}