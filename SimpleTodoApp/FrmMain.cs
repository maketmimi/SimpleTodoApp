using System;
using System.Windows.Forms;

// TODO add edit functionality
// TODO add attach file feature to the Task class

namespace SimpleTodoApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private uint _NumberOfCheckedTasks = 0;

        private void ClbTodoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnDeleteTask.Enabled = ClbTodoList.SelectedIndex != -1;
        }

        private void UpdateTasksInfoLable()
        {
            LbTasksInfo.Text = ClbTodoList.Items.Count == 0 ? "لا توجد مهام" : $"تم إنهاء " + _NumberOfCheckedTasks + " من " + ClbTodoList.Items.Count + " مهمة";
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            TaskTODO newTask = FrmInputTask.ReadNewTask();

            if (newTask != null)
            {
                ClbTodoList.Items.Add(newTask);
                UpdateTasksInfoLable();
                MessageBox.Show(".تمت إضافة مهمة جديدة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateTasksInfoLable();
        }

        private void ClbTodoList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                _NumberOfCheckedTasks++;
            else
                _NumberOfCheckedTasks--;

            UpdateTasksInfoLable();
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            ClbTodoList.Items.RemoveAt(ClbTodoList.SelectedIndex);
            _NumberOfCheckedTasks = ((uint)ClbTodoList.CheckedItems.Count);
            UpdateTasksInfoLable();
        }

        private void ClbTodoList_DoubleClick(object sender, EventArgs e)
        {
            if (ClbTodoList.SelectedIndex != -1)
                FrmViewTask.ViewTask((TaskTODO) ClbTodoList.Items[ClbTodoList.SelectedIndex]);
        }
    }
}
