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
    public delegate void ActionControl();

    public partial class FormPersonsZoo : Form
    {
        private ActionControl ac;
        private ActionControl rf;
        private int count;
        private IList<Person> Persons;

        public FormPersonsZoo()
        {
            InitializeComponent();
            Persons = new List<Person>();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ++count;

            ChildWindow childForm = new ChildWindow(Persons);

            childForm.MdiParent = this;

            ac += new ActionControl(childForm.Add);
            rf += new ActionControl(childForm.RefreshTable);

            childForm.Text = "Data Entry - " + count;

            childForm.Show();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                foreach (ActionControl r in rf.GetInvocationList())
                {
                    if (r != null)
                    {
                        r();
                    }
                }
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                foreach (ActionControl a in ac.GetInvocationList())
                {
                    if (a != null)
                    {
                        a();
                    }
                }
            }
        }

        private void FormPersonsZoo_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                WinActivStatus.Text = this.ActiveMdiChild.Text;
            }
            else
            {
                WinActivStatus.Text = "- None -";
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonAdd_Click(sender, e);
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            } 
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonClose_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutPersonZoo = new AboutBox();
            aboutPersonZoo.Show();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void FormPersonsZoo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString() == "N")
            {
                newToolStripMenuItem_Click(sender, e);
            }

            if (e.Control && e.KeyCode.ToString() == "S")
            {
                toolStripButtonAdd_Click(sender, e);
            }
        }


    }
}
