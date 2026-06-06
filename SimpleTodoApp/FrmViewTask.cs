using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SimpleTodoApp
{
    public partial class FrmViewTask : Form
    {
        private FrmViewTask(TaskTODO task)
        {
            InitializeComponent();

            if (task != null)
            {
                TxtTitle.Text = task.Title;
                TxtDescription.Text = task.Description;
                TxtCategory.Text = task.category.Name;

                if (task.DeadLine.HasValue)
                    TxtDeadLine.Text = task.DeadLine.Value.ToString("ddd, dd-MM-yyyy, hh:mm tt");
                else
                    TxtDeadLine.Text = "N/A";
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private static void ShowViewError()
        {
            MessageBox.Show("حدث خطأ غير متوقع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        public static void ViewTask(TaskTODO task)
        {
            if (task == null)
            {
                ShowViewError();
                return;
            }

            FrmViewTask frmView = new FrmViewTask(task);

            frmView.ShowDialog();
        }

    }
}
