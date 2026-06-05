using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

// TODO add attach file feature to the Task class

namespace SimpleTodoApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            LoadAllTasksIfAny();
        }

        private uint _NumberOfCheckedTasks = 0;
        private static string _PathToTasksFile = ".\\Tasks.txt";

        private void SaveAllTasks()
        {
            List<string> lRecords = new List<string>();

            foreach (TaskTODO task in ClbTodoList.Items)
            {
                lRecords.Add(task.ConvertToRecord());
            }

            string TasksTextToSave = string.Join(TaskTODO.TasksSeperator, lRecords);

            File.WriteAllText(_PathToTasksFile, TasksTextToSave);
        }

        // TODO I think I should improve this 
        private void LoadAllTasksIfAny()
        {
            if (!File.Exists(_PathToTasksFile)) return;

            string Records = File.ReadAllText(_PathToTasksFile);

            if (string.IsNullOrEmpty(Records)) return;
            
            string[] ArrRecords = Records.Split(new[] {TaskTODO.TasksSeperator}, StringSplitOptions.None);

            foreach (var Record in ArrRecords)
            {
                TaskTODO task = new TaskTODO(Record);
                ClbTodoList.Items.Add(task, task.IsChecked);
            }

            _NumberOfCheckedTasks = ((uint)ClbTodoList.CheckedItems.Count);
            UpdateTasksInfoLable();
        }

        private void ClbTodoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool itemSelected = ClbTodoList.SelectedIndex != -1;
           
            BtnDeleteTask.Visible = itemSelected;
            BtnEditTask.Visible = itemSelected;

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
                MessageBox.Show("تمت إضافة مهمة جديدة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
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

            ((TaskTODO)ClbTodoList.Items[e.Index]).IsChecked = e.NewValue == CheckState.Checked;

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

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (FrmInputTask.EditTask((TaskTODO)ClbTodoList.Items[ClbTodoList.SelectedIndex]))
            {
                MessageBox.Show(
                    "تم تعديل المهمة بنجاح",
                    "تم",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, 
                    MessageBoxOptions.RtlReading |
                    MessageBoxOptions.RightAlign
                    );
                ClbTodoList.Invalidate();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAllTasks();
        }
    
    }
}
