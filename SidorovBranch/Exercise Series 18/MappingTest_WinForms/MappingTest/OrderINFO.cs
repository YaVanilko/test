using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NHibernate.Cfg;
using NHibernate;

using MappingTest.Entities;
using System.Reflection;

namespace MappingTest
{
    public partial class OrderINFO : Form
    {

        Order order;
        IList<Order> orders;
        IList<Telephone> phones;


        public OrderINFO()
        {
            InitializeComponent();

            log4net.Config.XmlConfigurator.Configure();
            var nhConfig = new Configuration().Configure();
            nhConfig.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionFactory = nhConfig.BuildSessionFactory();



            orders = new List<Order>();
            phones = new List<Telephone>();

            for (int i = 1; i < 4; ++i)
            {
                using (ISession session = sessionFactory.OpenSession())
                {
                    order = session.QueryOver<Order>().Where(x => x.Id == i).SingleOrDefault();

                    orders.Add(order);
                    
                    Console.WriteLine("Description: " + order.Description);

                    Console.WriteLine("Packs in order:");
                    foreach (Pack p in order.Packs)
                    {
                        Console.WriteLine("Barcode " + p.Barcode + " / Weight " + p.Weight);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Sent " + order.ShipingDate.Date.ToString("d") + " - Receiv " + order.ReceivingDate.Date.ToString("d"));
                    Console.WriteLine();

                    Console.WriteLine("Sender Store");

                    Console.WriteLine("address " + order.SendingStore.Address);

                    Console.WriteLine(" /n Schedule " + order.SendingStore.Schedules.SchedulesStr);


                    for (int k = 0; k < order.SendingStore.Telephones.Count;++k )
                    {
                        phones.Add(order.SendingStore.Telephones[k]);
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = orders;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = phones;
        }
    }
}
