namespace Three_Layer
{
    partial class GUI_MonHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nup_SoTC = new System.Windows.Forms.NumericUpDown();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.lb_Ho = new System.Windows.Forms.Label();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.lb_MaSv = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gv_MonHoc = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_SoTC)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 248);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nup_SoTC);
            this.groupBox1.Controls.Add(this.lb_Ten);
            this.groupBox1.Controls.Add(this.lb_Ho);
            this.groupBox1.Controls.Add(this.txt_Ho);
            this.groupBox1.Controls.Add(this.lb_MaSv);
            this.groupBox1.Controls.Add(this.txt_MaSV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // nup_SoTC
            // 
            this.nup_SoTC.Location = new System.Drawing.Point(174, 115);
            this.nup_SoTC.Name = "nup_SoTC";
            this.nup_SoTC.Size = new System.Drawing.Size(120, 29);
            this.nup_SoTC.TabIndex = 7;
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten.Location = new System.Drawing.Point(32, 115);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(81, 23);
            this.lb_Ten.TabIndex = 5;
            this.lb_Ten.Text = "Số tín chỉ";
            // 
            // lb_Ho
            // 
            this.lb_Ho.AutoSize = true;
            this.lb_Ho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ho.Location = new System.Drawing.Point(32, 78);
            this.lb_Ho.Name = "lb_Ho";
            this.lb_Ho.Size = new System.Drawing.Size(109, 23);
            this.lb_Ho.TabIndex = 3;
            this.lb_Ho.Text = "Tên môn học";
            // 
            // txt_Ho
            // 
            this.txt_Ho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ho.Location = new System.Drawing.Point(174, 78);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(155, 29);
            this.txt_Ho.TabIndex = 2;
            // 
            // lb_MaSv
            // 
            this.lb_MaSv.AutoSize = true;
            this.lb_MaSv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaSv.Location = new System.Drawing.Point(32, 41);
            this.lb_MaSv.Name = "lb_MaSv";
            this.lb_MaSv.Size = new System.Drawing.Size(107, 23);
            this.lb_MaSv.TabIndex = 1;
            this.lb_MaSv.Text = "Mã môn học";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSV.Location = new System.Drawing.Point(174, 38);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(155, 29);
            this.txt_MaSV.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gv_MonHoc);
            this.panel3.Controls.Add(this.btn_Exit);
            this.panel3.Controls.Add(this.btn_Del);
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(992, 466);
            this.panel3.TabIndex = 9;
            // 
            // gv_MonHoc
            // 
            this.gv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_MonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_MonHoc.Location = new System.Drawing.Point(0, 137);
            this.gv_MonHoc.Name = "gv_MonHoc";
            this.gv_MonHoc.RowHeadersWidth = 51;
            this.gv_MonHoc.RowTemplate.Height = 24;
            this.gv_MonHoc.Size = new System.Drawing.Size(992, 329);
            this.gv_MonHoc.TabIndex = 9;
            this.gv_MonHoc.Click += new System.EventHandler(this.gv_MonHoc_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(574, 19);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(148, 59);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(397, 19);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(148, 59);
            this.btn_Del.TabIndex = 7;
            this.btn_Del.Text = "Xoá";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(219, 19);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(148, 59);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(41, 19);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(148, 59);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // GUI_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 714);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_MonHoc";
            this.Text = "GUI_MonHoc";
            this.Load += new System.EventHandler(this.GUI_MonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_SoTC)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_MonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.Label lb_Ho;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.Label lb_MaSv;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView gv_MonHoc;
        private System.Windows.Forms.NumericUpDown nup_SoTC;
    }
}