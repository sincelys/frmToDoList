using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace frmToDoList
{
    public partial class frmToDoList : Form
    {
        private const string filePath = @"tasks.txt"; 

        public frmToDoList()
        {
            InitializeComponent();
            LoadTasks(); 
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null) 
            {
                int index = lstTasks.SelectedIndex;
                string task = lstTasks.SelectedItem.ToString();
                if (!task.StartsWith("✓ ")) 
                {
                    lstTasks.Items[index] = "✓ " + task; 
                    SaveTasks(); 
                    UpdateTaskCount(); 
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text)) 
            {
                
                string task = txtTask.Text;
                DateTime dueDate = dtpDueDate.Value; 
                lstTasks.Items.Add(task + " - Due: " + dueDate.ToShortDateString()); 
                txtTask.Clear(); 
                UpdateTaskCount(); 
                SaveTasks(); 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null) 
            {
                txtTask.Text = lstTasks.SelectedItem.ToString(); 
                lstTasks.Items.Remove(lstTasks.SelectedItem); 
                UpdateTaskCount(); 
                SaveTasks(); 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null) 
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem); 
                UpdateTaskCount(); 
                SaveTasks(); 
            }
        }

        private void UpdateTaskCount() 
        {
            lblTotalTasks.Text = "Total Tasks: " + lstTasks.Items.Count;
        }

        private void SaveTasks()
        {
            try
            {
                File.WriteAllLines(filePath, lstTasks.Items.Cast<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tasks could not be saved. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTasks()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    if (lines.Length > 0)
                    {
                        lstTasks.Items.AddRange(lines); 
                    }
                    UpdateTaskCount(); 
                    UpdateTaskColors(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tasks could not be loaded. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void UpdateTaskColors()
        {
            foreach (var item in lstTasks.Items)
            {
                string task = item.ToString();
                int dueIndex = task.IndexOf("Due:");
                if (dueIndex != -1)
                {
                    
                    string dateStr = task.Substring(dueIndex + 4).Trim(); 
                    if (DateTime.TryParse(dateStr, out DateTime dueDate))
                    {
                        
                        TimeSpan timeDifference = dueDate - DateTime.Today;

                        
                        if (timeDifference.Days <= 2 && timeDifference.Days >= 0)
                        {
                            lstTasks.Items[lstTasks.Items.IndexOf(item)] = "⚠ " + task; 
                        }
                    }
                }
            }
        }

        private void frmToDoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasks(); 
            this.BackColor = Properties.Settings.Default.BackgroundColor;
        }

        private void btnChangePriority_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null) 
            {
                int index = lstTasks.SelectedIndex; 
                string task = lstTasks.SelectedItem.ToString(); 

                
                int starCount = task.Count(c => c == '*');

                
                if (starCount >= 3)
                {
                    lstTasks.Items[index] = task.Substring(0, task.Length - starCount); 
                }
                else
                {
                    lstTasks.Items[index] = task + "*"; 
                }

                lstTasks.SelectedIndex = index; 
                lstTasks.Refresh(); 

                SaveTasks(); 
                UpdateTaskCount(); 
            }
            else
            {
                MessageBox.Show("Please select a task.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            
            using (ColorDialog colorDialog = new ColorDialog())
            {
                
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    this.BackColor = colorDialog.Color;

                    
                    SaveBackgroundColor(colorDialog.Color);
                }
            }
        }

        
        private void SaveBackgroundColor(Color color)
        {
            
        }
    }
}
