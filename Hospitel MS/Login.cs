using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitel_MS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Clrebtn_Click(object sender, EventArgs e)
        {
            Adminbtn.Text = "";
            Passwordbtn.Text = "";
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(Adminbtn.Text==""&&Passwordbtn.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else if(Adminbtn.Text=="Admin"&&Passwordbtn.Text=="Password") 
            {
                Home obj= new Home();
                obj.Show();
                this.Hide();
            } 
             
            
        }
    }
}
