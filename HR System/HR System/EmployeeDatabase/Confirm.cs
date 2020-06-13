using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDatabase
{
    public partial class Confirm : Form
    {
        bool confirm = false;
        public Confirm()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            confirm = true;
            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            confirm = false;
            this.Close();
        }

        public bool ConfirmDelete()
        {
            return confirm;
        }    
    }
}
