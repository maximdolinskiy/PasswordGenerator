using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{

    public partial class PasswordGenerator : Form
    {


      int currentPasswordLength = 0;
      Random character = new Random();


        private void passwordGen(int passwordLength)
        {
            String allCharatcers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ012356789abcdefghijklmnopqrstuvwxyz!@#$%^&*";
            String randomPassword = "";

            for(int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0,allCharatcers.Length);
                randomPassword += allCharatcers[randomNum];
            }
            lblPassword.Text = randomPassword;

        }




        public PasswordGenerator()
        {


            InitializeComponent();
            passwordlengthSlider.Minimum = 5;
            passwordlengthSlider.Maximum = 20;
            passwordGen(5);
        }



        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPassword.Text);
        }

        private void passwordlengthSlider_Scroll(object sender, EventArgs e)
        {
            lblPasswordLength.Text = "Password Length: " + passwordlengthSlider.Value.ToString();
            currentPasswordLength = passwordlengthSlider.Value;
            passwordGen(currentPasswordLength);
        }
    }
}
