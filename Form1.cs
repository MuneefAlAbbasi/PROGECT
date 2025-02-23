using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progectt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(user.Text)||string.IsNullOrEmpty(password.Text)|| string.IsNullOrEmpty(contery.Text) || string.IsNullOrEmpty(date.Text) || string.IsNullOrEmpty(email.Text)){
                MessageBox.Show("plase full the fields");

            }
          else  if(!male.Checked&&!famle.Checked)
                {
                    MessageBox.Show("plase select the type");
                    return;

                }
            else
            {
             if(!IsValidEmail(email.Text))
                {
                    MessageBox.Show("plase enter email from correct");
                    return;

                }
             
           
                String type = male.Checked ? "male" : "famle";
                result.Text = $"user name is {user.Text}\n email is {email.Text}\n paswword is {password.Text}\n date is {date.Text} \n countery is {contery.Text}\n type is {type}";

            }
        }
     
        public static bool IsValidEmail(string email)
        {
            // تعبير عادي للتحقق من صحة البريد الإلكتروني
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

    }
}
