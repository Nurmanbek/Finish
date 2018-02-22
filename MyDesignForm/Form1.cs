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
using MaterialSkin;
using MaterialSkin.Controls;

namespace MyDesignForm
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.BlueGrey900, Primary.Blue700, Accent.Orange400, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                Main mn = new Main();
                mn.Show();
            }
            else
                MessageBox.Show("Error Username or Password!!!");
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
