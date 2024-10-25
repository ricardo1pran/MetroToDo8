using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroToDo
{
    public partial class MainUI : MetroSetForm
    {
        string mtd_helperDefault = "Metro ToDo v.1.0";

        public MainUI()
        {
            InitializeComponent();
        }

        private void showAbout(object sender, EventArgs e)
        {
            // show form about
        }

        private void showAlertOk(string title, string caption)
        {
            var alert = new Library.AlertOk(title, caption);
            alert.Show();
        }

        /*
         * Specific ToDo functions (Add, Delete, etc)
         * 
         * October 2024 - Ricardo Gunawan
         * 
         */

        public void addToDo()
        {
            if (tb_todoInput.Text != "")
            {
                lb_todo1.AddItem(tb_todoInput.Text);
                tb_todoInput.Text = "";
                tb_todoInput.Focus();
            }
            else
            {
                // toggle alert
                //MessageBox.Show(this, "No Text to Add","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                showAlertOk("ERROR", "No Text to Add!");
            }
        }

        public void deleteToDo()
        {
            if (lb_todo1.SelectedItem == null)
            {
                // toggle alert
                showAlertOk("ERROR ToDo", "Please select ToDo First");
                //MessageBox.Show(this, "Please select ToDo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //add toggle confirmation

                try
                {
                    if (lb_todo1.SelectedIndex >= 0)
                        lb_todo1.RemoveItemAt(lb_todo1.SelectedIndex);
                    else
                    {
                        showAlertOk("ERROR ToDo", "Please select ToDo First");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(this, "ERROR - " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    showAlertOk("ERROR ToDo", "Please select ToDo First");

                }
            }
        }

        public void completeToDo()
        {
            if (lb_todo1.SelectedItem == null)
            {
                // toggle alert
                showAlertOk("ERROR ToDo", "Please select ToDo First");
                //MessageBox.Show(this, "Please select ToDo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // check if completed

                // set values
                try
                {
                    var selectedTodo = lb_todo1.Items[lb_todo1.SelectedIndex].ToString();

                    //var completedToDo = "--(" + selectedTodo + ")-- Completed!";
                    //lb_todo1.Items[lb_todo1.SelectedIndex] = completedToDo;

                    lb_completed.AddItem(selectedTodo);
                    lb_todo1.RemoveItemAt(lb_todo1.SelectedIndex);
                }

                catch (Exception e)
                {
                    showAlertOk("ERROR ToDo", "Please select ToDo First");
                }
            }
        }

        public void setEditMode()
        {
            tb_todoInput.Text = lb_todo1.Items[lb_todo1.SelectedIndex].ToString();
            btn_edittodo.Text = "Cancel Edit";
            btn_addTodo.Text = "Edit ToDo!";
            btn_deltodo.Enabled = false;
            btn_complete.Enabled = false;
            lb_todo1.Enabled = false;
        }

        public void resetEditMode()
        {
            tb_todoInput.Text = "";
            btn_edittodo.Text = "Edit ToDo!";
            btn_addTodo.Text = "Add ToDo!";
            btn_deltodo.Enabled = true;
            btn_complete.Enabled = true;
            lb_todo1.Enabled = true;
        }

        public void editToDo()
        {
            if (lb_todo1.SelectedItem == null)
            {
                // toggle alert
                showAlertOk("ERROR ToDo", "Please select ToDo First");
                //MessageBox.Show(this, "Please select ToDo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lb_todo1.Items[lb_todo1.SelectedIndex] = tb_todoInput.Text;
                resetEditMode();
            }
        }

        /* ---------------- Completed ToDo ------------------ */

        public void uncompleteToDo()
        {
            if (lb_completed.SelectedItem == null)
            {
                // toggle alert
                showAlertOk("ERROR ToDo", "Please select Completed ToDo First");
                //MessageBox.Show(this, "Please select ToDo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // check if completed

                // set values
                try
                {
                    var selectedTodo = lb_completed.Items[lb_completed.SelectedIndex].ToString();

                    //var completedToDo = "--(" + selectedTodo + ")-- Completed!";
                    //lb_todo1.Items[lb_todo1.SelectedIndex] = completedToDo;

                    lb_todo1.AddItem(selectedTodo);
                    lb_completed.RemoveItemAt(lb_completed.SelectedIndex);
                }

                catch (Exception e)
                {
                    showAlertOk("ERROR ToDo", "Please select ToDo First");
                }
            }
        }

        /*
         * Common Form Events (Click, KeyDown, etc)
         * 
         * October 2024 - Ricardo Gunawan
         * 
         */

        private void btn_addTodo_Click(object sender, EventArgs e)
        {

            if (btn_addTodo.Text.Equals("Add ToDo!"))
            {
                addToDo();
            }
            else
            {
                editToDo();
            }
        }

        private void btn_deltodo_Click(object sender, EventArgs e)
        {
            deleteToDo();
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            completeToDo();
        }

        private void btn_edittodo_Click(object sender, EventArgs e)
        {
            if (lb_todo1.SelectedItem == null)
            {
                // toggle alert
                showAlertOk("ERROR ToDo", "Please select ToDo First");
                //MessageBox.Show(this, "Please select ToDo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btn_edittodo.Text.Equals("Edit ToDo!"))
                {
                    setEditMode();
                }
                else
                {
                    resetEditMode();
                }
            }
        }

        private void btn_clearlb1_Click(object sender, EventArgs e)
        {
            if(lb_todo1.Items.Count <= 0)
            {
                showAlertOk("Information", "The list is empty.");

            }else
            {
                lb_todo1.Clear();
            }

        }
        

        private void btnC_ClearC_Click(object sender, EventArgs e)
        {
            if (lb_completed.Items.Count <= 0)
            {
                showAlertOk("Information", "The list is empty.");

            }
            else
            {
                lb_completed.Clear();
            }
        }

        private void btnC_Uncomplete_Click(object sender, EventArgs e)
        {
            uncompleteToDo();
        }
    }
}
