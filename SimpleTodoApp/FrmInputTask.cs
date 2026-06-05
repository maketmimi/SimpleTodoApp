using System.Windows.Forms;

namespace SimpleTodoApp
{
    public partial class FrmInputTask : Form
    {
        private FrmInputTask()
        {
            InitializeComponent();
        }

        private TaskTODO _Task;

        public static TaskTODO ReadNewTask()
        {
            FrmInputTask taskBox = new FrmInputTask();

            taskBox.ShowDialog();

            return taskBox._IsCanceled ? null : taskBox._Task;
        }

        private bool _IsCanceled = false;
        private bool _IsFormClosedByCloseButton = true;

        private void CloseFormProgramaticly()
        {
            _IsFormClosedByCloseButton = false;
            this.Close();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTitle.Text.Trim()))
                MessageBox.Show("!إدخال خاطئ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _Task = new TaskTODO(TxtTitle.Text, TxtDescription.Text);
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
