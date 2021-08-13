using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeageManagementSystem.View
{
    public partial class RegularDashboard : Form
    {
        public RegularDashboard()
        {
            InitializeComponent();
        }

        private void EditRoundButon_Click(object sender, EventArgs e)
        {
            addRoundScoredUserControl1.Visible = false;
            editRoundUserControl1.Visible = true;
        }

        private void AddRoundButton_Click(object sender, EventArgs e)
        {
            addRoundScoredUserControl1.Visible = true;
            editRoundUserControl1.Visible = false;
        }
    }
}
