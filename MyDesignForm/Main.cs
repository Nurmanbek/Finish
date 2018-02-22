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
            WindowState = FormWindowState.Normal;
            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panelLeft.Width == 2)
            {
                panelLeft.Width = 175;
                this.button1.Visible = false;
            }
            else
            {
                this.button1.Visible = true;
                panelLeft.Width = 2;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width == 175)
            {
                panelLeft.Width = 2;
                this.button1.Visible = true;
            }
            else
            {
                panelLeft.Width = 175;
                this.button1.Visible = false;
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (panelRight.Width == 2)
            {
                panelRight.Width = 175;
                this.button67.Visible = false;
            }
            else
            {
                panelRight.Width = 2;
                this.button67.Visible = true;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (panelRight.Width == 175)
            {
                panelRight.Width = 2;
                this.button67.Visible = true;
            }
            else
            {
                this.button67.Visible = false;
                panelRight.Width = 175;
            }
        }
    }
}
