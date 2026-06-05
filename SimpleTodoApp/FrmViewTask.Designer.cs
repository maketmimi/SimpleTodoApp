namespace SimpleTodoApp
{
    partial class FrmViewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewTask));
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTitle
            // 
            this.TxtTitle.BackColor = System.Drawing.Color.White;
            this.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitle.Location = new System.Drawing.Point(12, 44);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.ReadOnly = true;
            this.TxtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTitle.Size = new System.Drawing.Size(642, 47);
            this.TxtTitle.TabIndex = 0;
            this.TxtTitle.TabStop = false;
            // 
            // TxtDescription
            // 
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(12, 144);
            this.TxtDescription.MaxLength = 0;
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ReadOnly = true;
            this.TxtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescription.Size = new System.Drawing.Size(642, 247);
            this.TxtDescription.TabIndex = 1;
            this.TxtDescription.TabStop = false;
            this.TxtDescription.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Almarai", 16F);
            this.label1.Location = new System.Drawing.Point(516, 107);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "وصف المهمة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Almarai", 16F);
            this.label2.Location = new System.Drawing.Point(516, 7);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "عنوان المهمة:";
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Almarai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(532, 397);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnClose.Size = new System.Drawing.Size(122, 36);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmViewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 443);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmViewTask";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "معلومات المهمة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
    }
}