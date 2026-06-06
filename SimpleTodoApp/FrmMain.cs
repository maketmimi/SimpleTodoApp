using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

// TODO add Time and Date for both deadlines and time of creation
// TODO add attach file feature to the Task class

namespace SimpleTodoApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            _TODOList = TaskTODO.LoadStTODOListFromFile(_PathToTasksFile);
        }

        private TaskTODO.StTODOList _TODOList;
        private readonly static string _PathToTasksFile = ".\\Tasks.txt";
        private readonly static string _PathToCategoriesFile = ".\\Categories.txt";

        private void ShowTasks(List<TaskTODO> lTasks)
        {
            foreach (var task in lTasks)
            {
                ClbTodoList.Items.Add(task, task.IsChecked);
            }
        }

        private void RefreshShownTasks()
        {
            if (ClbTodoList.SelectedIndex != -1)
                ClbTodoList.SetSelected(ClbTodoList.SelectedIndex, false);

            ClbTodoList.Items.Clear();
            ShowTasks(Category.FilterTasks(_TODOList.TasksList, (Category)CbCategories.SelectedItem));
        }

        private void RefreshButtonsVisibilty()
        {
            bool itemSelected = ClbTodoList.SelectedIndex != -1;

            BtnDeleteTask.Visible = itemSelected;
            BtnEditTask.Visible = itemSelected;
            BtnShowMore.Visible = itemSelected;

        }

        private void ClbTodoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshButtonsVisibilty();
        }

        private void UpdateTasksInfoLable()
        {
            LbTasksInfo.Text = _TODOList.TasksList.Count == 0 ? "لا توجد مهام" : $"تم إنهاء " + _TODOList.NumberOfCheckedItems + " من " + _TODOList.TasksList.Count + " مهمة";
        }
        
        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            TaskTODO newTask = FrmInputTask.ReadNewTask();

            if (newTask != null)
            {
                _TODOList.TasksList.Add(newTask);
                RefreshShownTasks();
                UpdateTasksInfoLable();
                MessageBox.Show("تمت إضافة مهمة جديدة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }

        private void LoadCategories(List<Category> lCategories)
        {
            if (lCategories == null) return;

            foreach (var Category in lCategories)
            {
                CbCategories.Items.Add(Category);
            }
        }

        private void SaveCategories()
        {
            List<Category> lCategories = CbCategories.Items.Cast<Category>().ToList();

            lCategories.Remove(new Category("كل المهام"));

            Category.SaveCategoriesToFile(_PathToCategoriesFile, lCategories);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CbCategories.Items.Add(new Category("كل المهام"));
            CbCategories.SelectedIndex = 0;
            LoadCategories(Category.LoadCategoriesFromFile(_PathToCategoriesFile));
            RefreshShownTasks();
            UpdateTasksInfoLable();
        }

        private void ClbTodoList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // this line because of the Tasks added by the refresh method
            if ((e.NewValue == CheckState.Checked) == ((TaskTODO)ClbTodoList.Items[e.Index]).IsChecked)
                return;

            if (e.NewValue == CheckState.Checked)
                _TODOList.NumberOfCheckedItems++;
            else
                _TODOList.NumberOfCheckedItems--;

            ((TaskTODO)ClbTodoList.Items[e.Index]).IsChecked = e.NewValue == CheckState.Checked;

            UpdateTasksInfoLable();
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            if (ClbTodoList.SelectedIndex == -1) return;

            if (((TaskTODO)ClbTodoList.Items[ClbTodoList.SelectedIndex]).IsChecked)
                _TODOList.NumberOfCheckedItems--;

            _TODOList.TasksList.Remove((TaskTODO)ClbTodoList.Items[ClbTodoList.SelectedIndex]);
            ClbTodoList.Items.RemoveAt(ClbTodoList.SelectedIndex);

            UpdateTasksInfoLable();
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (ClbTodoList.SelectedIndex == -1) return;

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
                RefreshShownTasks();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TaskTODO.SaveTasksToFile(_PathToTasksFile, _TODOList.TasksList); // you have to always understand every line of code you write in your code , keep that in mind mate
            SaveCategories();
        }

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshShownTasks();
        }

        private void BtnShowMore_Click(object sender, EventArgs e)
        {
            if (ClbTodoList.SelectedIndex != -1)
                FrmViewTask.ViewTask((TaskTODO)ClbTodoList.Items[ClbTodoList.SelectedIndex]);
        }
    
    }
}
