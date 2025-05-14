namespace _1_1View_UC
{
    partial class OneToOneViewUC
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneToOneViewUC));
            this.cboCasernes = new System.Windows.Forms.ComboBox();
            this.lblTypeEngin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCasernes
            // 
            this.cboCasernes.FormattingEnabled = true;
            this.cboCasernes.Location = new System.Drawing.Point(837, 126);
            this.cboCasernes.Name = "cboCasernes";
            this.cboCasernes.Size = new System.Drawing.Size(206, 21);
            this.cboCasernes.TabIndex = 0;
            // 
            // lblTypeEngin
            // 
            this.lblTypeEngin.AutoSize = true;
            this.lblTypeEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeEngin.Location = new System.Drawing.Point(368, 117);
            this.lblTypeEngin.Name = "lblTypeEngin";
            this.lblTypeEngin.Size = new System.Drawing.Size(109, 39);
            this.lblTypeEngin.TabIndex = 5;
            this.lblTypeEngin.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(557, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(274, 115);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(102)))));
            this.btnLast.FlatAppearance.BorderSize = 4;
            this.btnLast.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateBlue;
            this.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(102)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(604, 490);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 75);
            this.btnLast.TabIndex = 4;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::_1_1View_UC.Properties.Resources.F;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(102)))));
            this.btnNext.FlatAppearance.BorderSize = 4;
            this.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateBlue;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(102)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(523, 490);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 75);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::_1_1View_UC.Properties.Resources.B;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(102)))));
            this.btnPrevious.FlatAppearance.BorderSize = 4;
            this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateBlue;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(102)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(442, 490);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 75);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(102)))));
            this.btnFirst.FlatAppearance.BorderSize = 4;
            this.btnFirst.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateBlue;
            this.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(102)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(361, 490);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 75);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // OneToOneViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTypeEngin);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.cboCasernes);
            this.Name = "OneToOneViewUC";
            this.Size = new System.Drawing.Size(1046, 606);
            this.Load += new System.EventHandler(this.OneToOneViewUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCasernes;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblTypeEngin;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
