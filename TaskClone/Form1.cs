using System.Diagnostics;

namespace TaskClone
{
    public partial class Group3_Task : Form
    {
        Process[] process;
        public Group3_Task()
        {
            InitializeComponent();
        }

        void GetProcess()
        {
            process = Process.GetProcesses();
            foreach (var item in process)
            {
                ListViewItem process = new ListViewItem() { Text = item.ProcessName };
                process.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Id.ToString() });
                process.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.WorkingSet64.ToString() });
                lv_process.Items.Add(process);
            }
        }

        private void Group3_Task_Load(object sender, EventArgs e)
        {
            GetProcess();
        }

        private void Reload()
        {
            lv_process.Items.Clear();
            GetProcess();
        }

        private void btn_kill_Click(object sender, EventArgs e)
        {
            if (lv_process.SelectedItems.Count > 0)
            {
                foreach (var item in process)
                {
                    if (item.ProcessName == lv_process.SelectedItems[0].Text)
                    {
                        DialogResult result = MessageBox.Show($"Bạn thực sự muốn đóng tiến trình {lv_process.SelectedItems[0].Text}", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            item.Kill();
                            MessageBox.Show("Đóng thành công tiến trình!", "", MessageBoxButtons.OK);
                            Reload();
                            return;
                        }
                    }
                }

            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}