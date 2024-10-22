using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.View
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            timerTime.Start();
        }

        private void BtnPhieu_Click(object sender, EventArgs e)
        {
            if (pnlPhieu.Visible == true)
                pnlPhieu.Visible = false;
            else
                pnlPhieu.Visible = true;

        }

        private void BtnMenuClose_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 233)
            {
                pnlMenu.Width = 52;
                btnMenuSize.Text = "→";
            }
            else
            {
                pnlMenu.Width = 233;
                btnMenuSize.Text = "←";
            }
        }

        private void BtnDSPhieu_Click(object sender, EventArgs e)
        {
            FormDSPhieu formDSPhieu = new FormDSPhieu();
            formDSPhieu.TopLevel = false;
            pnlContainer.Controls.Add(formDSPhieu);
            formDSPhieu.Show();
        }

        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
