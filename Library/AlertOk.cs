using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroSet_UI.Forms;
using System.Windows.Forms;

namespace MetroToDo.Library
{
    public partial class AlertOk : MetroSetForm
    {

        public AlertOk()
        {
            InitializeComponent();
        }

        public AlertOk(string alertTitle, string alertCaption)
        {
            InitializeComponent();
            //ActiveForm.Text = alertTitle;
            this.Text = alertTitle;
            this.alertLabel.Text = alertCaption;
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void metroSetLabel1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
