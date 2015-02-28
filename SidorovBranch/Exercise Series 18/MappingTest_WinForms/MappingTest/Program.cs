using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate.Cfg;
using NHibernate;

using MappingTest.Entities;
using System.Reflection;

using System.Windows.Forms;


namespace MappingTest
{
    class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new OrderINFO());

        }
    }
}
