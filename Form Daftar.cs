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
    public partial class Form_Daftar : Form
    {
        Function func = new Function();
        public Form_Daftar()
        {
            InitializeComponent();
        }

        public string Incrementid()
        {
            DataRowCollection col = func.GetData("SELECT id FROM OrderHeader");
            return col.Count.ToString("D4");
        }

        public string IdMember()
        {
            DataRowCollection col = func.GetData("SELECT id FROM MsMember WHERE name LIKE '");
            return col[0][0].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Hide();
        }
    }
}
