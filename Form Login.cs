using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_App
{
    public partial class Form_Login : Form 
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        Function func = new Function();

        void login()
        {
            string query = "SELECT id, role, id_outlet FROM tb_user WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";

            int count = func.GetData(query).Count;

            try
            {
                if (count > 0)
                {
                    foreach (DataRow dr in func.GetData(query))
                    {
                        if (dr["role"].ToString().Equals("admin"))
                        {
                            new Admin_Form().Show();
                            this.Hide();
                        }
                        else if (dr["role"].ToString().Equals("owner"))
                        {
                            new Owner_Form().Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Maaf Data Tidak Valid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void labelDaftar_Click(object sender, EventArgs e)
        {
            new Form_Daftar().Show();
            this.Hide();
        }
    }
}
