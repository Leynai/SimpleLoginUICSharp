using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFrontExample
{
    public partial class Login : Form
    {
        String SaveText;
        String[] DefaultTextBoxText = {"Usuario","Contraseña" };
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            WelcomLabel.Focus();
        }

        private void ClearSampleText(object sender, EventArgs e)
        {
            
            TextBox TB = sender as TextBox;
            SaveText = TB.Text;
            if (DefaultTextBoxText.Contains(TB.Text))
            {
                if (TB.Text == DefaultTextBoxText[1])
                {
                    TB.PasswordChar = '*';
                }
                TB.Text = "";
            }
        }

        private void IfTextboxEmpty(object sender, EventArgs e)
        {
            TextBox TB = sender as TextBox;
            if (TB.Text == "")
            {
                if (SaveText == DefaultTextBoxText[1])
                {
                    TB.PasswordChar = '\0';
                }
                TB.Text = SaveText;
            }
        }
    }
}
