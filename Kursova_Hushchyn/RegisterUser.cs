using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_Hushchyn
{
    public partial class RegisterUser : Form
    {
        UserList userList;  
        public RegisterUser(UserList users)
        {
            this.userList = users;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(txtMoney.Text, out double money)==true&&!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)&&txtPassword.Text.Length>4) 
            {
                if (money > 0)
                {
                    bool isValid = false;
                    string mail = txtEmail.Text;
                    for (int i = 0; i < mail.Length; i++)
                    {
                        if (i > 0 && i < mail.Length - 2 && mail[i] == '@')
                        {
                            for (int j = i + 1; j < mail.Length; j++)
                            {
                                if (j < mail.Length && mail[j] == '.')
                                {
                                    isValid = true;
                                }
                            }

                        }
                    }
                    if (isValid == true)
                    {
                        if (!string.IsNullOrWhiteSpace(txtName.Text))
                        {
                            if (!string.IsNullOrWhiteSpace(txtSurname.Text))
                            {
                                if (DateTime.TryParse(txtDate.Text,out DateTime date))
                                {
                                    DateTime tmp = date;
                                    tmp = tmp.AddYears(14);
                                    if (tmp.Date > DateTime.UtcNow)
                                    {
                                        User user = new User(txtName.Text, txtSurname.Text, date, txtEmail.Text, txtPassword.Text, money, false);
                                        foreach (User u in userList.Users)
                                        {
                                            if (u==user)
                                            {
                                                MessageBox.Show("This user is already registered");
                                                return;
                                            }
                                        }
                                        
                                        userList.Users.Add(user);
                                        MessageBox.Show("You have successfully registered!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Input correct Surname");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Input correct Name");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Input correct email");
                    }
                }
                else
                {
                    MessageBox.Show("Input correct balance");
                }
            }
            else
            {
                MessageBox.Show("Input correct information");
            }
        }
    }
}
