using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using MetroFramework.Controls;
using MetroFramework.Animation;
using MetroFramework.Forms;

namespace MyDesignForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }
        

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.PhoneBooks". При необходимости она может быть перемещена или удалена.

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panelLeft.Width == 3)
            {
                panelLeft.Width = 220;
                this.button1.Visible = false;
            }
            else
            {
                this.button1.Visible = true;
                panelLeft.Width = 3;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width == 220)
            {
                panelLeft.Width = 3;
                this.button1.Visible = true;
            }
            else
            {
                panelLeft.Width = 220;
                this.button1.Visible = false;
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (panelRight.Width == 3)
            {
                panelRight.Width = 220;
                this.button67.Visible = false;
            }
            else
            {
                panelRight.Width = 3;
                this.button67.Visible = true;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (panelRight.Width == 220)
            {
                panelRight.Width = 3;
                this.button67.Visible = true;
            }
            else
            {
                this.button67.Visible = false;
                panelRight.Width = 220;
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
