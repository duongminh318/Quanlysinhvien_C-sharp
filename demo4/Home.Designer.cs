
namespace demo4
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmonhoc = new System.Windows.Forms.Button();
            this.bntadduser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiem
            // 
            this.btnDiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiem.Location = new System.Drawing.Point(32, 148);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(150, 49);
            this.btnDiem.TabIndex = 0;
            this.btnDiem.Text = "Quản Lý Điểm";
            this.btnDiem.UseVisualStyleBackColor = false;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.SystemColors.Control;
            this.btnSinhVien.Location = new System.Drawing.Point(32, 216);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(150, 55);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "Thông Tin Sinh Viên";
            this.btnSinhVien.UseVisualStyleBackColor = false;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(586, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 62);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(331, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Điểm Sinh Viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tra Cứu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmonhoc
            // 
            this.btnmonhoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnmonhoc.Location = new System.Drawing.Point(32, 68);
            this.btnmonhoc.Name = "btnmonhoc";
            this.btnmonhoc.Size = new System.Drawing.Size(150, 49);
            this.btnmonhoc.TabIndex = 5;
            this.btnmonhoc.Text = "Thông Tin Môn Học";
            this.btnmonhoc.UseVisualStyleBackColor = false;
            this.btnmonhoc.Click += new System.EventHandler(this.btnmonhoc_Click);
            // 
            // bntadduser
            // 
            this.bntadduser.Location = new System.Drawing.Point(32, 381);
            this.bntadduser.Name = "bntadduser";
            this.bntadduser.Size = new System.Drawing.Size(150, 57);
            this.bntadduser.TabIndex = 6;
            this.bntadduser.Text = "Cấp Quyền Truy Cập";
            this.bntadduser.UseVisualStyleBackColor = true;
            this.bntadduser.Click += new System.EventHandler(this.bntadduser_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntadduser);
            this.Controls.Add(this.btnmonhoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.btnDiem);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmonhoc;
        private System.Windows.Forms.Button bntadduser;
    }
}