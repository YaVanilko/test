using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonsInfo
{
    public partial class ChildWindow : Form
    {
        private IList<Person> Persons;

        public ChildWindow(IList<Person> Prs)
        {
            InitializeComponent();
            this.Persons = Prs;
            gridControlPersonsZoo.DataSource = this.Persons;
        }

        private void ChildWindow_Load(object sender, EventArgs e)
        {

        }

        public void Add()
        {
            if (this.ParentForm != null &&
                this.ParentForm.ActiveMdiChild == this)
            {
                Persons.Add(new Person(textEditFirstName.Text,
                                       textEditLasstName.Text,
                                       textEditMiddleName.Text,
                                       dateTimePicketBirth.Value.ToString()));

                gridViewZoo.RefreshData();
            }
        }

        public void RefreshTable()
        {
            gridViewZoo.RefreshData();
        }
    }
}
