using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Infrastructure;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DbHelper.Configure();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            abonent.Name = tbName.Text;
            abonent.BirtDay = DateTime.Now;

            TypeInfo type = new TypeInfo();
            type.Name = tbType.Text;

            Phone phone = new Phone();
            phone.Abonent = abonent;
            phone.Value = tvPhone.Text;
            phone.Info = type;

            
            DbHelper.InsertContact(phone);


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tbList.Text = DbHelper.AllAbonent().ToString();
        }


    }
}
