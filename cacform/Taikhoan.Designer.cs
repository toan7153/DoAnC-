namespace QuanLyQuanCafe
{
    partial class Taikhoan
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.iBtnDSBxem = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBsua = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBxoa = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBthem = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(241, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GenG Coffee";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxType);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDisplayName);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(547, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 493);
            this.panel2.TabIndex = 3;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cbxType.Location = new System.Drawing.Point(133, 261);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(182, 24);
            this.cbxType.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(133, 321);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(182, 22);
            this.txtMatKhau.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(58, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mật khẩu";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(133, 194);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(182, 22);
            this.txtDisplayName.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(133, 132);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(29, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(40, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(29, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iBtnDSBxem);
            this.panel3.Controls.Add(this.iBtnDSBsua);
            this.panel3.Controls.Add(this.iBtnDSBxoa);
            this.panel3.Controls.Add(this.iBtnDSBthem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 76);
            this.panel3.TabIndex = 4;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 176);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.Size = new System.Drawing.Size(547, 417);
            this.dgvAccount.TabIndex = 5;
            // 
            // iBtnDSBxem
            // 
            this.iBtnDSBxem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBxem.FlatAppearance.BorderSize = 0;
            this.iBtnDSBxem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBxem.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBxem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iBtnDSBxem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxem.Location = new System.Drawing.Point(419, 9);
            this.iBtnDSBxem.Name = "iBtnDSBxem";
            this.iBtnDSBxem.Size = new System.Drawing.Size(107, 56);
            this.iBtnDSBxem.TabIndex = 3;
            this.iBtnDSBxem.Text = "Xem";
            this.iBtnDSBxem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBxem.UseVisualStyleBackColor = false;
            this.iBtnDSBxem.Click += new System.EventHandler(this.iBtnDSBxem_Click);
            // 
            // iBtnDSBsua
            // 
            this.iBtnDSBsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBsua.FlatAppearance.BorderSize = 0;
            this.iBtnDSBsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBsua.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBsua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iBtnDSBsua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBsua.Location = new System.Drawing.Point(285, 7);
            this.iBtnDSBsua.Name = "iBtnDSBsua";
            this.iBtnDSBsua.Size = new System.Drawing.Size(107, 56);
            this.iBtnDSBsua.TabIndex = 2;
            this.iBtnDSBsua.Text = "Sửa";
            this.iBtnDSBsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBsua.UseVisualStyleBackColor = false;
            this.iBtnDSBsua.Click += new System.EventHandler(this.iBtnDSBsua_Click);
            // 
            // iBtnDSBxoa
            // 
            this.iBtnDSBxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBxoa.FlatAppearance.BorderSize = 0;
            this.iBtnDSBxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBxoa.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBxoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iBtnDSBxoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxoa.Location = new System.Drawing.Point(148, 7);
            this.iBtnDSBxoa.Name = "iBtnDSBxoa";
            this.iBtnDSBxoa.Size = new System.Drawing.Size(107, 56);
            this.iBtnDSBxoa.TabIndex = 1;
            this.iBtnDSBxoa.Text = "Xoá";
            this.iBtnDSBxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBxoa.UseVisualStyleBackColor = false;
            this.iBtnDSBxoa.Click += new System.EventHandler(this.iBtnDSBxoa_Click);
            // 
            // iBtnDSBthem
            // 
            this.iBtnDSBthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBthem.FlatAppearance.BorderSize = 0;
            this.iBtnDSBthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBthem.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBthem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnDSBthem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBthem.Location = new System.Drawing.Point(12, 7);
            this.iBtnDSBthem.Name = "iBtnDSBthem";
            this.iBtnDSBthem.Size = new System.Drawing.Size(107, 56);
            this.iBtnDSBthem.TabIndex = 0;
            this.iBtnDSBthem.Text = "Thêm";
            this.iBtnDSBthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBthem.UseVisualStyleBackColor = false;
            this.iBtnDSBthem.Click += new System.EventHandler(this.iBtnDSBthem_Click);
            // 
            // Taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Taikhoan";
            this.Text = "Taikhoan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iBtnDSBxem;
        private FontAwesome.Sharp.IconButton iBtnDSBsua;
        private FontAwesome.Sharp.IconButton iBtnDSBxoa;
        private FontAwesome.Sharp.IconButton iBtnDSBthem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxType;
    }
}