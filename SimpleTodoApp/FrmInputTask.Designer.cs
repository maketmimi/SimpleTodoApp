namespace SimpleTodoApp
{
    partial class FrmInputTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInputTask));
            this.BtnDone = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDone
            // 
            this.BtnDone.BackColor = System.Drawing.Color.Transparent;
            this.BtnDone.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.BtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDone.Font = new System.Drawing.Font("Almarai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDone.Location = new System.Drawing.Point(513, 404);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDone.Size = new System.Drawing.Size(141, 48);
            this.BtnDone.TabIndex = 2;
            this.BtnDone.Text = "تم";
            this.BtnDone.UseVisualStyleBackColor = false;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Almarai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(366, 404);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(141, 48);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "إلغاء";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Almarai", 16F);
            this.label2.Location = new System.Drawing.Point(516, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "عنوان المهمة:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(12, 151);
            this.TxtDescription.MaxLength = 0;
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescription.Size = new System.Drawing.Size(642, 247);
            this.TxtDescription.TabIndex = 1;
            this.TxtDescription.WordWrap = false;
            // 
            // TxtTitle
            // 
            this.TxtTitle.BackColor = System.Drawing.Color.White;
            this.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitle.Location = new System.Drawing.Point(12, 46);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTitle.Size = new System.Drawing.Size(642, 54);
            this.TxtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Almarai", 16F);
            this.label1.Location = new System.Drawing.Point(516, 114);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "وصف المهمة:";
            // 
            // FrmInputTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInputTask";
            this.ShowInTaskbar = false;
            this.Text = "إدخال مهمة";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInputTaskBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label1;
    }
}