using CafeManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
     public partial class FormDangNhap : Form
     {
          public FormDangNhap()
          {
               InitializeComponent();
          }

          private void btnLogIn_MouseEnter(object sender, EventArgs e)
          {
               btnLogIn.BackColor = Color.FromArgb(93, 64, 55);
               btnLogIn.ForeColor = Color.White;
          }

          private void btnLogIn_MouseLeave(object sender, EventArgs e)
          {
               btnLogIn.BackColor = Color.White;
               btnLogIn.ForeColor = Color.FromArgb(184, 128, 103);
          }

          private void btnClose_Click(object sender, EventArgs e)
          {
               Environment.Exit(0);
          }

          private void btnLogIn_Click(object sender, EventArgs e)
          {
               this.Hide();
               FormChinh frmChinh = new FormChinh();
          }
     }
}
