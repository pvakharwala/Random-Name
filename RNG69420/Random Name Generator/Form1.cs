using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Name_Generator
{
    public partial class Form1 : Form
    {
        public String fn;
        public String ln;
        public string[] fnlt;
        public string[] lnlt;
        public Form1()
        {

            fn = Properties.Resources.Firstname.ToString();
            ln = Properties.Resources.Lastname.ToString();
            fnlt = fn.Replace("\r\n", ",").Split(',');
            lnlt = ln.Replace("\r\n", ",").Split(',');
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            
            Random rn = new Random();
            int sel_fn = rn.Next(1,999);
            int sel_ln = rn.Next(1, 99);
            firstNameTextbox.Text = fnlt[sel_fn].ToString();
            lastNameTextbox.Text = lnlt[sel_ln].ToString();
        }
    }
}
