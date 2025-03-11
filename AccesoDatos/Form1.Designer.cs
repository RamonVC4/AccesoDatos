namespace AccesoDatos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            btnAuthors = new Button();
            btnEmployee = new Button();
            btnTitles = new Button();
            btnDiscounts = new Button();
            btnJobs = new Button();
            btnPubInfo = new Button();
            btnPublishers = new Button();
            btnSales = new Button();
            btnStores = new Button();
            btnTitleAuthor = new Button();
            btnRoysched = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(124, 3);
            label1.Name = "label1";
            label1.Size = new Size(690, 60);
            label1.TabIndex = 1;
            label1.Text = "Administrador de Base de Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 25);
            label3.Name = "label3";
            label3.Size = new Size(42, 451);
            label3.TabIndex = 3;
            label3.Text = "G\r\nR\r\nU\r\nP\r\nO\r\n\r\nF\r\nE\r\nN\r\nI\r\nX";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 522);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.ForeColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(124, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 10);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(302, 79);
            label2.Name = "label2";
            label2.Size = new Size(298, 41);
            label2.TabIndex = 6;
            label2.Text = "Base de Datos: Pubs";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Location = new Point(124, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(675, 10);
            panel3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(124, 136);
            label4.Name = "label4";
            label4.Size = new Size(262, 38);
            label4.TabIndex = 7;
            label4.Text = "Tablas disponibles:";
            // 
            // btnAuthors
            // 
            btnAuthors.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAuthors.Location = new Point(136, 195);
            btnAuthors.Name = "btnAuthors";
            btnAuthors.Size = new Size(261, 46);
            btnAuthors.TabIndex = 8;
            btnAuthors.Text = "Authors";
            btnAuthors.UseVisualStyleBackColor = true;
            btnAuthors.Click += button1_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployee.Location = new Point(403, 195);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(261, 46);
            btnEmployee.TabIndex = 9;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnTitles
            // 
            btnTitles.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTitles.Location = new Point(136, 247);
            btnTitles.Name = "btnTitles";
            btnTitles.Size = new Size(261, 46);
            btnTitles.TabIndex = 10;
            btnTitles.Text = "Titles";
            btnTitles.UseVisualStyleBackColor = true;
            btnTitles.Click += btnTitles_Click;
            // 
            // btnDiscounts
            // 
            btnDiscounts.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiscounts.Location = new Point(403, 247);
            btnDiscounts.Name = "btnDiscounts";
            btnDiscounts.Size = new Size(261, 46);
            btnDiscounts.TabIndex = 11;
            btnDiscounts.Text = "Discounts";
            btnDiscounts.UseVisualStyleBackColor = true;
            // 
            // btnJobs
            // 
            btnJobs.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJobs.Location = new Point(136, 299);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(261, 46);
            btnJobs.TabIndex = 12;
            btnJobs.Text = "Jobs";
            btnJobs.UseVisualStyleBackColor = true;
            // 
            // btnPubInfo
            // 
            btnPubInfo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPubInfo.Location = new Point(403, 299);
            btnPubInfo.Name = "btnPubInfo";
            btnPubInfo.Size = new Size(261, 46);
            btnPubInfo.TabIndex = 13;
            btnPubInfo.Text = "Pub Info";
            btnPubInfo.UseVisualStyleBackColor = true;
            // 
            // btnPublishers
            // 
            btnPublishers.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPublishers.Location = new Point(136, 351);
            btnPublishers.Name = "btnPublishers";
            btnPublishers.Size = new Size(261, 46);
            btnPublishers.TabIndex = 14;
            btnPublishers.Text = "Publishers";
            btnPublishers.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSales.Location = new Point(403, 351);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(261, 46);
            btnSales.TabIndex = 15;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // btnStores
            // 
            btnStores.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStores.Location = new Point(136, 403);
            btnStores.Name = "btnStores";
            btnStores.Size = new Size(261, 46);
            btnStores.TabIndex = 16;
            btnStores.Text = "Stores";
            btnStores.UseVisualStyleBackColor = true;
            // 
            // btnTitleAuthor
            // 
            btnTitleAuthor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTitleAuthor.Location = new Point(403, 403);
            btnTitleAuthor.Name = "btnTitleAuthor";
            btnTitleAuthor.Size = new Size(261, 46);
            btnTitleAuthor.TabIndex = 17;
            btnTitleAuthor.Text = "Title Author";
            btnTitleAuthor.UseVisualStyleBackColor = true;
            // 
            // btnRoysched
            // 
            btnRoysched.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoysched.Location = new Point(136, 455);
            btnRoysched.Name = "btnRoysched";
            btnRoysched.Size = new Size(261, 46);
            btnRoysched.TabIndex = 18;
            btnRoysched.Text = "Roysched";
            btnRoysched.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_03_04_141134;
            pictureBox1.Location = new Point(698, 417);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(403, 455);
            button1.Name = "button1";
            button1.Size = new Size(261, 46);
            button1.TabIndex = 71;
            button1.Text = "Roysched";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 537);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRoysched);
            Controls.Add(btnTitleAuthor);
            Controls.Add(btnStores);
            Controls.Add(btnSales);
            Controls.Add(btnPublishers);
            Controls.Add(btnPubInfo);
            Controls.Add(btnJobs);
            Controls.Add(btnDiscounts);
            Controls.Add(btnTitles);
            Controls.Add(btnEmployee);
            Controls.Add(btnAuthors);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label4;
        private Button btnAuthors;
        private Button btnEmployee;
        private Button btnTitles;
        private Button btnDiscounts;
        private Button btnJobs;
        private Button btnPubInfo;
        private Button btnPublishers;
        private Button btnSales;
        private Button btnStores;
        private Button btnTitleAuthor;
        private Button btnRoysched;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
