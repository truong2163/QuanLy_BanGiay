
namespace Nhom11_Quanlybangiay.FrmLogin1
{
    partial class frmQuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTk = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLayLaiMatKhau = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(14, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(14, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(14, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(14, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên của bạn";
            // 
            // txtMaTk
            // 
            this.txtMaTk.Location = new System.Drawing.Point(132, 267);
            this.txtMaTk.MaxLength = 25;
            this.txtMaTk.Name = "txtMaTk";
            this.txtMaTk.Size = new System.Drawing.Size(181, 30);
            this.txtMaTk.TabIndex = 0;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(132, 343);
            this.txtSoDT.MaxLength = 10;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(181, 30);
            this.txtSoDT.TabIndex = 2;
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(132, 381);
            this.txtDiaChi.MaxLength = 25;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(181, 30);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(132, 305);
            this.txtTenTK.MaxLength = 25;
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(181, 30);
            this.txtTenTK.TabIndex = 1;
            this.txtTenTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenTK_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vui lòng cung cấp những thông tin sau:";
            // 
            // btnLayLaiMatKhau
            // 
            this.btnLayLaiMatKhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLayLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLayLaiMatKhau.ForeColor = System.Drawing.Color.Lime;
            this.btnLayLaiMatKhau.Location = new System.Drawing.Point(62, 445);
            this.btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            this.btnLayLaiMatKhau.Size = new System.Drawing.Size(208, 63);
            this.btnLayLaiMatKhau.TabIndex = 6;
            this.btnLayLaiMatKhau.Text = "Lấy lại mật khẩu";
            this.btnLayLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnLayLaiMatKhau.Click += new System.EventHandler(this.btnLayLaiMatKhau_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(62, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Nhom11_Quanlybangiay.Properties.Resources.quenpass;
            this.ClientSize = new System.Drawing.Size(332, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLayLaiMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtMaTk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy lại mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTk;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLayLaiMatKhau;
        private System.Windows.Forms.Button button1;
    }
}