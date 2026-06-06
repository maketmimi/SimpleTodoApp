using System.Linq;
using System.Windows.Forms;

namespace SimpleTodoApp
{
    public partial class FrmInputTask : Form
    {
        private FrmInputTask()
        {
            InitializeComponent();
            _Task = new TaskTODO("", "", false, null);
        }

        private FrmInputTask(TaskTODO taskToEdit)
        {
            InitializeComponent();
            _Task = taskToEdit;
            LoadFormWithTaskToEdit(_Task);
        }

        private readonly TaskTODO _Task;

        private void LoadFormWithTaskToEdit(TaskTODO taskToEdit)
        {
            TxtTitle.Text = taskToEdit.Title;
            TxtDescription.Text = taskToEdit.Description;
            TxtCategory.Text = taskToEdit.category.Name;
        }

        public static TaskTODO ReadNewTask()
        {
            FrmInputTask taskBox = new FrmInputTask();

            taskBox.ShowDialog();

            return taskBox._IsCanceled ? null : taskBox._Task;
        }

        public static bool EditTask(TaskTODO taskToEdit)
        {
            if (taskToEdit == null) return false;

            FrmInputTask frmInputTask = new FrmInputTask(taskToEdit);

            frmInputTask.ShowDialog();

            return !frmInputTask._IsCanceled;
        }

        private bool _IsCanceled = false;
        private bool _IsFormClosedByCloseButton = true;

        private void CloseFormProgramaticly()
        {
            _IsFormClosedByCloseButton = false;
            this.Close();
        }

        private bool ContainsAny(string str, string[] arrValues)
        {
            if (str == null) return false;

            foreach (var value in arrValues)
            {
                if (str.Contains(value))
                    return true;
            }

            return false;
        }

        private void BtnDone_Click(object sender, System.EventArgs e)
        {
            string[] InvalidInputs = {TaskTODO.RecordSeperator, TaskTODO.TasksSeperator};

            if (string.IsNullOrEmpty(TxtTitle.Text.Trim()) || ContainsAny(TxtTitle.Text, InvalidInputs) || ContainsAny(TxtDescription.Text, InvalidInputs) || ContainsAny(TxtCategory.Text, InvalidInputs))
                MessageBox.Show("إدخال خاطئ!\n\nيجب أن لا تقوم بإدخال هذه الرموز:\n[TASK]\n#//#", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            else
            {
                _Task.Title = TxtTitle.Text;
                _Task.Description = TxtDescription.Text;
                _Task.category = new Category(TxtCategory.Text);

                CloseFormProgramaticly(); // indicates success
            }
        }
    
        private void Cancel(object sender, System.EventArgs e)
        {
            _IsCanceled = true;
            CloseFormProgramaticly();   
        }

        private void FrmInputTaskBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_IsFormClosedByCloseButton)
                _IsCanceled = true;
        }
        
    }
}
