namespace DONGHO.Forms
{
    partial class Form_NCC
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label4 = new Label();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            txtTen = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            label2 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            label12 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvNCC = new DataGridView();
            button1 = new Button();
            button9 = new Button();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(17, 145, 249);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(1337, 48);
            label4.TabIndex = 71;
            label4.Text = "Nhà Cung Cấp";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(17, 145, 249);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(120, 294);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(179, 57);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Ngừng hợp tác";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(17, 145, 249);
            btnCapNhat.FlatAppearance.BorderSize = 0;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapNhat.Location = new Point(307, 294);
            btnCapNhat.Margin = new Padding(4, 5, 4, 5);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(124, 57);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(17, 145, 249);
            btnThem.BackgroundImageLayout = ImageLayout.None;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(439, 294);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(124, 57);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.White;
            txtTen.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTen.ForeColor = Color.Black;
            txtTen.Location = new Point(120, 29);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(556, 34);
            txtTen.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(120, 191);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(556, 34);
            txtEmail.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.White;
            txtSDT.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT.ForeColor = Color.Black;
            txtSDT.Location = new Point(120, 137);
            txtSDT.Margin = new Padding(4, 5, 4, 5);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(556, 34);
            txtSDT.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 58;
            label2.Text = "Tên NCC";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.White;
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.ForeColor = Color.Black;
            txtDiaChi.Location = new Point(120, 83);
            txtDiaChi.Margin = new Padding(4, 5, 4, 5);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(556, 34);
            txtDiaChi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(47, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 58;
            label3.Text = "Email";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(56, 146);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(53, 25);
            label12.TabIndex = 58;
            label12.Text = "SĐT";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(31, 92);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 25);
            label10.TabIndex = 59;
            label10.Text = "Địa Chỉ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnCapNhat);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(txtTen);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtSDT);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtDiaChi);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 5);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(692, 368);
            panel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Silver;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 637F));
            tableLayoutPanel1.Controls.Add(dgvNCC, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 48);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 378F));
            tableLayoutPanel1.Size = new Size(1337, 378);
            tableLayoutPanel1.TabIndex = 70;
            // 
            // dgvNCC
            // 
            dgvNCC.AllowUserToAddRows = false;
            dgvNCC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(17, 145, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvNCC.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNCC.Dock = DockStyle.Fill;
            dgvNCC.Location = new Point(704, 5);
            dgvNCC.Margin = new Padding(4, 5, 4, 5);
            dgvNCC.MultiSelect = false;
            dgvNCC.Name = "dgvNCC";
            dgvNCC.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvNCC.RowHeadersVisible = false;
            dgvNCC.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(17, 145, 249);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgvNCC.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNCC.Size = new Size(629, 368);
            dgvNCC.TabIndex = 1;
            dgvNCC.Click += dgvNCC_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 133, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.Close;
            button1.Location = new Point(1293, 0);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(44, 48);
            button1.TabIndex = 69;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(51, 51, 51);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.Red;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(1043, 0);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "button9";
            button9.Size = new Size(44, 48);
            button9.TabIndex = 72;
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // Form_NCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1337, 426);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button9);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_NCC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNCC";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Button button9;
    }
}