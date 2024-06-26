﻿using System;
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
            this.KeyPreview = true;
        }

        private void Submit()
        {
            if (double.TryParse(txtMoney.Text, out double money) == true && !string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(lblPass.Text) && lblPass.Text.Length > 4)
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
                                if (j < mail.Length && mail[j] == '.' && j>i+1)
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
                                if (DateTime.TryParse(txtDate.Text, out DateTime date))
                                {
                                    DateTime tmp = date;
                                    tmp = tmp.AddYears(14);
                                    if (tmp.Date < DateTime.UtcNow)
                                    {
                                        User user = new User(txtName.Text, txtSurname.Text, date, txtEmail.Text, txtPassword.Text, money, false);
                                        foreach (User u in userList.Users)
                                        {
                                            if (u.Email == user.Email)
                                            {
                                                MessageBox.Show("This user is already registered");
                                                return;
                                            }
                                        }

                                        userList.Users.Add(user);
                                        userList.SaveToFile("users.txt");
                                        MessageBox.Show("You have successfully registered!");
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("You`re too young");

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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
           Submit();
        }
        private void ShowHelp()
        {

            MessageBox.Show("Menu for registration", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void RegisterUser_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (ActiveControl is TextBox || ActiveControl is ComboBox)
                    {
                        SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    else
                    {
                        Submit();
                    }
                   
                    e.Handled = true;
                    break;
                case Keys.F1:
                    ShowHelp();
                    e.Handled = true;
                    break;
                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
                case Keys.Up:
                    MoveFocusUp();
                    e.Handled = true;
                    break;
                case Keys.Down:
                    MoveFocusDown();
                    e.Handled = true;
                    break;
                case Keys.Left:
                    MoveFocusLeft();
                    e.Handled = true;
                    break;
                case Keys.Right:
                    MoveFocusRight();
                    e.Handled = true;
                    break;
                case Keys.Tab:
                    if (e.Shift)
                    {

                        this.SelectNextControl(this.ActiveControl, false, true, true, true);
                    }
                    else
                    {

                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    }
                    e.Handled = true;
                    break;
            }
        }
        private void MoveFocusUp()
        {
            if (ActiveControl == lblPass)
                txtDate.Focus();
            else if (ActiveControl == txtDate)
                txtName.Focus();


            if (ActiveControl == txtMoney)
                txtEmail.Focus();
            else if (ActiveControl == txtEmail)
                txtSurname.Focus();

        }
        private void MoveFocusDown()
        {
            if (ActiveControl == txtName)
                txtDate.Focus();
            else if (ActiveControl == txtDate)
                lblPass.Focus();

            if (ActiveControl == txtSurname)
                txtEmail.Focus();
            else if (ActiveControl == txtEmail)
                txtMoney.Focus();
        }

        private void MoveFocusLeft()
        {
            if (ActiveControl == txtMoney)
                lblPass.Focus();
            else if (ActiveControl == lblPass)
                txtMoney.Focus(); 

            if (ActiveControl == txtEmail)
                txtDate.Focus();
            else if (ActiveControl == txtDate)
                txtEmail.Focus(); 
        }
        private void MoveFocusRight()
        {
            if (ActiveControl == lblPass)
                txtMoney.Focus();
            else if (ActiveControl == txtMoney)
                lblPass.Focus(); 

            if (ActiveControl == txtDate)
                txtEmail.Focus();
            else if (ActiveControl == txtEmail)
                txtDate.Focus(); 
        }

    }
}
