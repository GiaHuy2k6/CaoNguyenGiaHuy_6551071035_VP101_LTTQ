namespace WinFormsApp
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
            label2 = new Label();
            txtMaCV = new TextBox();
            txtTenCV = new TextBox();
            txtLuongThang = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvCongViec = new DataGridView();
            btnXoa = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCongViec).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 71);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC CÔNG VIỆC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 101);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Thông tin công việc";
            // 
            // txtMaCV
            // 
            txtMaCV.Location = new Point(259, 145);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(125, 27);
            txtMaCV.TabIndex = 2;
            // 
            // txtTenCV
            // 
            txtTenCV.Location = new Point(259, 186);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.Size = new Size(125, 27);
            txtTenCV.TabIndex = 3;
            // 
            // txtLuongThang
            // 
            txtLuongThang.Location = new Point(259, 231);
            txtLuongThang.Name = "txtLuongThang";
            txtLuongThang.Size = new Size(125, 27);
            txtLuongThang.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 148);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 5;
            label3.Text = "Mã công việc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 189);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 6;
            label4.Text = "Tên công việc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 234);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 7;
            label5.Text = "Lương tháng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 269);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 8;
            label6.Text = "Danh Sách Công Việc";
            // 
            // dgvCongViec
            // 
            dgvCongViec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCongViec.Location = new Point(227, 269);
            dgvCongViec.Name = "dgvCongViec";
            dgvCongViec.RowHeadersWidth = 51;
            dgvCongViec.Size = new Size(373, 146);
            dgvCongViec.TabIndex = 9;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(576, 180);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(576, 225);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(576, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(576, 139);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(dgvCongViec);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLuongThang);
            Controls.Add(txtTenCV);
            Controls.Add(txtMaCV);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCongViec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaCV;
        private TextBox txtTenCV;
        private TextBox txtLuongThang;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvCongViec;
        private Button button1;
        private Button button2;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnThem;
        private Button btnSua;
    }
}
