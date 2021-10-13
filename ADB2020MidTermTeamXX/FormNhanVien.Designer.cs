
namespace ADB2020MidTermTeamXX
{
    partial class FormNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CongTy = new System.Windows.Forms.ComboBox();
            this.ButtonThem = new System.Windows.Forms.Button();
            this.Luong = new System.Windows.Forms.TextBox();
            this.Skill = new System.Windows.Forms.TextBox();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.MaNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CongTy);
            this.groupBox1.Controls.Add(this.ButtonThem);
            this.groupBox1.Controls.Add(this.Luong);
            this.groupBox1.Controls.Add(this.Skill);
            this.groupBox1.Controls.Add(this.HoTen);
            this.groupBox1.Controls.Add(this.MaNhanVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(17, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // CongTy
            // 
            this.CongTy.FormattingEnabled = true;
            this.CongTy.Location = new System.Drawing.Point(462, 16);
            this.CongTy.Name = "CongTy";
            this.CongTy.Size = new System.Drawing.Size(298, 27);
            this.CongTy.TabIndex = 8;
            // 
            // ButtonThem
            // 
            this.ButtonThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonThem.Location = new System.Drawing.Point(18, 182);
            this.ButtonThem.Name = "ButtonThem";
            this.ButtonThem.Size = new System.Drawing.Size(84, 41);
            this.ButtonThem.TabIndex = 7;
            this.ButtonThem.Text = "Thêm";
            this.ButtonThem.UseVisualStyleBackColor = true;
            this.ButtonThem.Click += new System.EventHandler(this.ButtonThem_Click);
            // 
            // Luong
            // 
            this.Luong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Luong.Location = new System.Drawing.Point(130, 136);
            this.Luong.Name = "Luong";
            this.Luong.Size = new System.Drawing.Size(206, 26);
            this.Luong.TabIndex = 4;
            // 
            // Skill
            // 
            this.Skill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Skill.Location = new System.Drawing.Point(130, 97);
            this.Skill.Name = "Skill";
            this.Skill.Size = new System.Drawing.Size(630, 26);
            this.Skill.TabIndex = 3;
            // 
            // HoTen
            // 
            this.HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoTen.Location = new System.Drawing.Point(130, 57);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(630, 26);
            this.HoTen.TabIndex = 2;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaNhanVien.Location = new System.Drawing.Point(130, 22);
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Size = new System.Drawing.Size(206, 26);
            this.MaNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Công ty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Skill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // GridNhanVien
            // 
            this.GridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNhanVien.Location = new System.Drawing.Point(17, 256);
            this.GridNhanVien.Name = "GridNhanVien";
            this.GridNhanVien.RowTemplate.Height = 25;
            this.GridNhanVien.Size = new System.Drawing.Size(766, 187);
            this.GridNhanVien.TabIndex = 3;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridNhanVien);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonThem;
        private System.Windows.Forms.TextBox Luong;
        private System.Windows.Forms.TextBox Skill;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox MaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridNhanVien;
        private System.Windows.Forms.ComboBox CongTy;
    }
}