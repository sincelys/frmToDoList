namespace frmToDoList
{
    partial class frmToDoList
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
            lblTitle = new Label();
            txtTask = new TextBox();
            btnAdd = new Button();
            lstTasks = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnMarkComplete = new Button();
            lblTotalTasks = new Label();
            btnChangePriority = new Button();
            btnChangeBackgroundColor = new Button();
            dtpDueDate = new DateTimePicker();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(125, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "To-Do List";
            // 
            // txtTask
            // 
            txtTask.Font = new Font("Segoe UI", 12F);
            txtTask.Location = new Point(20, 50);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(320, 34);
            txtTask.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(350, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstTasks
            // 
            lstTasks.Font = new Font("Segoe UI", 12F);
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 28;
            lstTasks.Location = new Point(20, 90);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(450, 200);
            lstTasks.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightBlue;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.Location = new Point(20, 300);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 30);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Task";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(166, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMarkComplete
            // 
            btnMarkComplete.BackColor = Color.Orange;
            btnMarkComplete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMarkComplete.Location = new Point(312, 300);
            btnMarkComplete.Name = "btnMarkComplete";
            btnMarkComplete.Size = new Size(170, 30);
            btnMarkComplete.TabIndex = 6;
            btnMarkComplete.Text = "Mark Completed";
            btnMarkComplete.UseVisualStyleBackColor = false;
            btnMarkComplete.Click += btnMarkComplete_Click;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.BackColor = Color.DarkBlue;
            lblTotalTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalTasks.Location = new Point(20, 340);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(250, 30);
            lblTotalTasks.TabIndex = 7;
            lblTotalTasks.Text = "Total Tasks: 0";
            // 
            // btnChangePriority
            // 
            btnChangePriority.BackColor = Color.DarkGreen;
            btnChangePriority.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnChangePriority.ForeColor = Color.Black;
            btnChangePriority.Location = new Point(281, 340);
            btnChangePriority.Name = "btnChangePriority";
            btnChangePriority.Size = new Size(135, 29);
            btnChangePriority.TabIndex = 8;
            btnChangePriority.Text = "Task Priority";
            btnChangePriority.UseVisualStyleBackColor = false;
            btnChangePriority.Click += btnChangePriority_Click;
            // 
            // btnChangeBackgroundColor
            // 
            btnChangeBackgroundColor.BackColor = Color.Purple;
            btnChangeBackgroundColor.ForeColor = SystemColors.ActiveCaptionText;
            btnChangeBackgroundColor.Location = new Point(422, 340);
            btnChangeBackgroundColor.Name = "btnChangeBackgroundColor";
            btnChangeBackgroundColor.Size = new Size(60, 48);
            btnChangeBackgroundColor.TabIndex = 9;
            btnChangeBackgroundColor.Text = "Color";
            btnChangeBackgroundColor.UseVisualStyleBackColor = false;
            btnChangeBackgroundColor.Click += btnChangeBackgroundColor_Click;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(20, 373);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 11;
            // 
            // frmToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(482, 403);
            Controls.Add(dtpDueDate);
            Controls.Add(btnChangeBackgroundColor);
            Controls.Add(btnChangePriority);
            Controls.Add(lblTotalTasks);
            Controls.Add(btnMarkComplete);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lstTasks);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(lblTitle);
            Name = "frmToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To-Do List Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTask;
        private Button btnAdd;
        private ListBox lstTasks;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnMarkComplete;
        private Label lblTotalTasks;
        private Button btnChangePriority;
        private Button btnChangeBackgroundColor;
        private DateTimePicker dtpDueDate;
    }
}
