namespace TaskClone
{
    partial class Group3_Task
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_kill = new Button();
            lv_process = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btn_reload = new Button();
            SuspendLayout();
            // 
            // btn_kill
            // 
            btn_kill.FlatStyle = FlatStyle.Flat;
            btn_kill.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kill.Location = new Point(618, 671);
            btn_kill.Name = "btn_kill";
            btn_kill.Size = new Size(112, 37);
            btn_kill.TabIndex = 0;
            btn_kill.Text = "End";
            btn_kill.UseVisualStyleBackColor = true;
            btn_kill.Click += btn_kill_Click;
            // 
            // lv_process
            // 
            lv_process.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lv_process.Location = new Point(12, 23);
            lv_process.MultiSelect = false;
            lv_process.Name = "lv_process";
            lv_process.Size = new Size(718, 628);
            lv_process.TabIndex = 1;
            lv_process.UseCompatibleStateImageBehavior = false;
            lv_process.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Process name";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PID";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Physical memory usage ";
            columnHeader3.Width = 180;
            // 
            // btn_reload
            // 
            btn_reload.BackgroundImageLayout = ImageLayout.None;
            btn_reload.FlatStyle = FlatStyle.Flat;
            btn_reload.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reload.Location = new Point(486, 671);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(103, 37);
            btn_reload.TabIndex = 2;
            btn_reload.Text = "Reload";
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // Group3_Task
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 720);
            Controls.Add(btn_reload);
            Controls.Add(lv_process);
            Controls.Add(btn_kill);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Group3_Task";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Group3_Task_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_kill;
        private ListView lv_process;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btn_reload;
    }
}