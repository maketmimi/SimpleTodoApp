using System.Windows.Forms;

namespace SimpleTodoApp
{
    public partial class FrmInputTaskBox : Form
    {
        private FrmInputTaskBox()
        {
            InitializeComponent();
        }

        public static string ReadNewTask()
        {
            FrmInputTaskBox taskBox = new FrmInputTaskBox();

            taskBox.ShowDialog();

            return taskBox._IsCanceled ? null : taskBox.TxtTask.Text;
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
            if (string.IsNullOrEmpty(TxtTask.Text.Trim()))
                MessageBox.Show("!إدخال خاطئ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                CloseFormProgramaticly();
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
