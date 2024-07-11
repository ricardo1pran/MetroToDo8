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

        private void btn_addTodo_Click(object sender, EventArgs e)
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
                MessageBox.Show(this, "No Text to Add","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_deltodo_Click(object sender, EventArgs e)
        {
            if(lb_todo1.SelectedItem == null)
            {
                // toggle alert
                var alert = new Library.AlertOk("ERROR ToDo", "Please select ToDo First");
                alert.Show();
            //MessageBox.Show(this, "Please select ToDo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                //add toggle confirmation
                lb_todo1.RemoveItemAt(lb_todo1.SelectedIndex);
            }
        }
    }
}
