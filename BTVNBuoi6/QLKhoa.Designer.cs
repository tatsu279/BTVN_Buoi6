namespace Buoi6
{
    partial class QLKhoa
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
            this.dgvkhoa = new System.Windows.Forms.DataGridView();
            this.Them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txtslgiaosu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhoa.Location = new System.Drawing.Point(473, 78);
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.RowHeadersWidth = 51;
            this.dgvkhoa.RowTemplate.Height = 24;
            this.dgvkhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkhoa.Size = new System.Drawing.Size(481, 294);
            this.dgvkhoa.TabIndex = 0;
            this.dgvkhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhoa_CellClick);
            this.dgvkhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhoa_CellContentClick);
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(12, 405);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(119, 44);
            this.Them.TabIndex = 1;
            this.Them.Text = "them";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(149, 405);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(119, 44);
            this.sua.TabIndex = 1;
            this.sua.Text = "sua";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(286, 405);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(119, 44);
            this.xoa.TabIndex = 1;
            this.xoa.Text = "xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(835, 405);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(119, 44);
            this.exit.TabIndex = 1;
            this.exit.Text = "Dong";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(149, 120);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(218, 22);
            this.txtmakhoa.TabIndex = 2;
            // 
            // txtslgiaosu
            // 
            this.txtslgiaosu.Location = new System.Drawing.Point(149, 235);
            this.txtslgiaosu.Name = "txtslgiaosu";
            this.txtslgiaosu.Size = new System.Drawing.Size(218, 22);
            this.txtslgiaosu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ma khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ten khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "so luong giao su";
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(149, 174);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(218, 22);
            this.txttenkhoa.TabIndex = 2;
            // 
            // QLKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtslgiaosu);
            this.Controls.Add(this.txttenkhoa);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.dgvkhoa);
            this.Name = "QLKhoa";
            this.Text = "QLKhoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLKhoa_FormClosing);
            this.Load += new System.EventHandler(this.QLKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvkhoa;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txtslgiaosu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenkhoa;
    }
}