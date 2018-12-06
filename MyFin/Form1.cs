using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFin
{
    public partial class Form1 : Form
    {
        bool night = false;
        string tableName;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuDirectoryUsers_Click(object sender, EventArgs e)
        {
            Users newUsers = new Users();
            newUsers.Show();
        }

        private void menuDirectoryIncome_Click(object sender, EventArgs e)
        {
            Income newIncome = new Income();
            newIncome.Show();
        }

        private void menuDirectoryIncomeCategory_Click(object sender, EventArgs e)
        {
            Income_category newIncome_category = new Income_category();
            newIncome_category.Show();
        }

        private void menuDirectoryCosts_Click(object sender, EventArgs e)
        {
            Costs newCosts = new Costs();
            newCosts.Show();
        }

        private void menuDirectoryCostsCategory_Click(object sender, EventArgs e)
        {
            Costs_category newCosts_category = new Costs_category();
            newCosts_category.Show();
        }
          
        private void menuAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs newAboutUs = new AboutUs();
            newAboutUs.Show();
        }

        private void Balanсe_Click(object sender, EventArgs e)
        {
            Balance newBalance = new Balance();
            newBalance.Show();
        }

        private void menuDayTheme_Click(object sender, EventArgs e)
        {
            night = false;
        }

        private void menuNightTheme_Click(object sender, EventArgs e)
        {
            night = true;
        }
    }
}
