using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PracticeTask8
{
    public partial class LoginForm : Form
    {
        private const string UsersFile = "users.dat";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Пожалуйста, введите логин!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveUser(login);

            MainForm mainForm = new MainForm(login);
            mainForm.Show();
            this.Hide();
        }

        private void SaveUser(string login)
        {
            User currentUser = new User(login);

            List<User> users = new List<User>();
            if (File.Exists(UsersFile))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(UsersFile, FileMode.Open))
                    {
                        users = (List<User>)formatter.Deserialize(fs);
                    }
                }
                catch { }
            }

            bool exists = false;
            foreach (var u in users)
            {
                if (u.Login == login)
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                users.Add(currentUser);
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(UsersFile, FileMode.Create))
                {
                    formatter.Serialize(fs, users);
                }
            }
        }
    }
}