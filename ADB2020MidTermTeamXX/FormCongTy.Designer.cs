
namespace ADB2020MidTermTeamXX
{
    partial class FormCongTy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCongTy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaCongTy = new System.Windows.Forms.TextBox();
            this.TenCongTy = new System.Windows.Forms.TextBox();
            this.SoNha = new System.Windows.Forms.TextBox();
            this.DuongPho = new System.Windows.Forms.TextBox();
            this.MaSoThue = new System.Windows.Forms.TextBox();
            this.Quan = new System.Windows.Forms.TextBox();
            this.ButtonThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongTy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonThem);
            this.groupBox1.Controls.Add(this.Quan);
            this.groupBox1.Controls.Add(this.MaSoThue);
            this.groupBox1.Controls.Add(this.DuongPho);
            this.groupBox1.Controls.Add(this.SoNha);
            this.groupBox1.Controls.Add(this.TenCongTy);
            this.groupBox1.Controls.Add(this.MaCongTy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin công ty";
            // 
            // dgvCongTy
            // 
            this.dgvCongTy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongTy.Location = new System.Drawing.Point(12, 260);
            this.dgvCongTy.Name = "dgvCongTy";
            this.dgvCongTy.RowTemplate.Height = 25;
            this.dgvCongTy.Size = new System.Drawing.Size(766, 187);
            this.dgvCongTy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã công ty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên công ty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã số thuế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số nhà";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đường phố";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(365, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quận";
            // 
            // MaCongTy
            // 
            this.MaCongTy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaCongTy.Location = new System.Drawing.Point(130, 22);
            this.MaCongTy.Name = "MaCongTy";
            this.MaCongTy.ReadOnly = true;
            this.MaCongTy.Size = new System.Drawing.Size(206, 26);
            this.MaCongTy.TabIndex = 1;
            // 
            // TenCongTy
            // 
            this.TenCongTy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenCongTy.Location = new System.Drawing.Point(130, 57);
            this.TenCongTy.Name = "TenCongTy";
            this.TenCongTy.Size = new System.Drawing.Size(206, 26);
            this.TenCongTy.TabIndex = 2;
            // 
            // SoNha
            // 
            this.SoNha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoNha.Location = new System.Drawing.Point(130, 97);
            this.SoNha.Name = "SoNha";
            this.SoNha.Size = new System.Drawing.Size(206, 26);
            this.SoNha.TabIndex = 3;
            // 
            // DuongPho
            // 
            this.DuongPho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DuongPho.Location = new System.Drawing.Point(130, 136);
            this.DuongPho.Name = "DuongPho";
            this.DuongPho.Size = new System.Drawing.Size(206, 26);
            this.DuongPho.TabIndex = 4;
            // 
            // MaSoThue
            // 
            this.MaSoThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaSoThue.Location = new System.Drawing.Point(462, 19);
            this.MaSoThue.Name = "MaSoThue";
            this.MaSoThue.Size = new System.Drawing.Size(191, 26);
            this.MaSoThue.TabIndex = 5;
            // 
            // Quan
            // 
            this.Quan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quan.Location = new System.Drawing.Point(462, 100);
            this.Quan.Name = "Quan";
            this.Quan.Size = new System.Drawing.Size(191, 26);
            this.Quan.TabIndex = 6;
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
            // FormCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 461);
            this.Controls.Add(this.dgvCongTy);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCongTy";
            this.Text = "FormCongTy";
            this.Load += new System.EventHandler(this.FormCongTy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongTy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCongTy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonThem;
        private System.Windows.Forms.TextBox Quan;
        private System.Windows.Forms.TextBox MaSoThue;
        private System.Windows.Forms.TextBox DuongPho;
        private System.Windows.Forms.TextBox SoNha;
        private System.Windows.Forms.TextBox TenCongTy;
        private System.Windows.Forms.TextBox MaCongTy;
    }
}