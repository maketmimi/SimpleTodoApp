namespace SimpleTodoApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ClbTodoList = new System.Windows.Forms.CheckedListBox();
            this.LbTasksInfo = new System.Windows.Forms.Label();
            this.BtnAddTask = new System.Windows.Forms.Button();
            this.BtnDeleteTask = new System.Windows.Forms.Button();
            this.BtnEditTask = new System.Windows.Forms.Button();
            this.CbCategories = new System.Windows.Forms.ComboBox();
            this.BtnShowMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClbTodoList
            // 
            this.ClbTodoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.ClbTodoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClbTodoList.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ClbTodoList.ForeColor = System.Drawing.Color.Black;
            this.ClbTodoList.FormattingEnabled = true;
            this.ClbTodoList.IntegralHeight = false;
            this.ClbTodoList.Location = new System.Drawing.Point(216, 101);
            this.ClbTodoList.Name = "ClbTodoList";
            this.ClbTodoList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClbTodoList.Size = new System.Drawing.Size(346, 302);
            this.ClbTodoList.TabIndex = 1;
            this.ClbTodoList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbTodoList_ItemCheck);
            this.ClbTodoList.SelectedIndexChanged += new System.EventHandler(this.ClbTodoList_SelectedIndexChanged);
            // 
            // LbTasksInfo
            // 
            this.LbTasksInfo.BackColor = System.Drawing.Color.Transparent;
            this.LbTasksInfo.Font = new System.Drawing.Font("Almarai", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTasksInfo.ForeColor = System.Drawing.Color.Black;
            this.LbTasksInfo.Location = new System.Drawing.Point(12, 16);
            this.LbTasksInfo.Name = "LbTasksInfo";
            this.LbTasksInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbTasksInfo.Size = new System.Drawing.Size(754, 45);
            this.LbTasksInfo.TabIndex = 1;
            this.LbTasksInfo.Text = "N/A";
            this.LbTasksInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.BtnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddTask.Font = new System.Drawing.Font("Almarai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTask.Location = new System.Drawing.Point(488, 409);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddTask.Size = new System.Drawing.Size(74, 33);
            this.BtnAddTask.TabIndex = 0;
            this.BtnAddTask.Text = "إضافة";
            this.BtnAddTask.UseVisualStyleBackColor = false;
            this.BtnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // BtnDeleteTask
            // 
            this.BtnDeleteTask.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDeleteTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDeleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteTask.Font = new System.Drawing.Font("Almarai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteTask.Location = new System.Drawing.Point(328, 409);
            this.BtnDeleteTask.Name = "BtnDeleteTask";
            this.BtnDeleteTask.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDeleteTask.Size = new System.Drawing.Size(74, 33);
            this.BtnDeleteTask.TabIndex = 3;
            this.BtnDeleteTask.TabStop = false;
            this.BtnDeleteTask.Text = "حذف";
            this.BtnDeleteTask.UseVisualStyleBackColor = false;
            this.BtnDeleteTask.Visible = false;
            this.BtnDeleteTask.Click += new System.EventHandler(this.BtnDeleteTask_Click);
            // 
            // BtnEditTask
            // 
            this.BtnEditTask.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnEditTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.BtnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditTask.Font = new System.Drawing.Font("Almarai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditTask.Location = new System.Drawing.Point(408, 409);
            this.BtnEditTask.Name = "BtnEditTask";
            this.BtnEditTask.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnEditTask.Size = new System.Drawing.Size(74, 33);
            this.BtnEditTask.TabIndex = 4;
            this.BtnEditTask.TabStop = false;
            this.BtnEditTask.Text = "تعديل";
            this.BtnEditTask.UseVisualStyleBackColor = false;
            this.BtnEditTask.Visible = false;
            this.BtnEditTask.Click += new System.EventHandler(this.BtnEditTask_Click);
            // 
            // CbCategories
            // 
            this.CbCategories.BackColor = System.Drawing.Color.White;
            this.CbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategories.Font = new System.Drawing.Font("Almarai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCategories.ForeColor = System.Drawing.Color.Black;
            this.CbCategories.FormattingEnabled = true;
            this.CbCategories.Location = new System.Drawing.Point(422, 67);
            this.CbCategories.Name = "CbCategories";
            this.CbCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbCategories.Size = new System.Drawing.Size(140, 28);
            this.CbCategories.TabIndex = 2;
            this.CbCategories.SelectedIndexChanged += new System.EventHandler(this.CbCategories_SelectedIndexChanged);
            // 
            // BtnShowMore
            // 
            this.BtnShowMore.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowMore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnShowMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnShowMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.BtnShowMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowMore.Font = new System.Drawing.Font("Almarai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowMore.Location = new System.Drawing.Point(248, 409);
            this.BtnShowMore.Name = "BtnShowMore";
            this.BtnShowMore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnShowMore.Size = new System.Drawing.Size(74, 33);
            this.BtnShowMore.TabIndex = 6;
            this.BtnShowMore.TabStop = false;
            this.BtnShowMore.Text = "المزيد";
            this.BtnShowMore.UseVisualStyleBackColor = false;
            this.BtnShowMore.Visible = false;
            this.BtnShowMore.Click += new System.EventHandler(this.BtnShowMore_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 458);
            this.Controls.Add(this.BtnShowMore);
            this.Controls.Add(this.CbCategories);
            this.Controls.Add(this.BtnEditTask);
            this.Controls.Add(this.BtnDeleteTask);
            this.Controls.Add(this.BtnAddTask);
            this.Controls.Add(this.LbTasksInfo);
            this.Controls.Add(this.ClbTodoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "مدير المهام";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClbTodoList;
        private System.Windows.Forms.Label LbTasksInfo;
        private System.Windows.Forms.Button BtnAddTask;
        private System.Windows.Forms.Button BtnDeleteTask;
        private System.Windows.Forms.Button BtnEditTask;
        private System.Windows.Forms.ComboBox CbCategories;
        private System.Windows.Forms.Button BtnShowMore;
    }
}

