using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using System.Reflection;
using NHibernate;

namespace PersonMapping
{
    class Program
    {
        static void Main(string[] args)
        {

            var nhConfig = new Configuration().Configure();
            nhConfig.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionFactory = nhConfig.BuildSessionFactory();
             
            Person person;

            using (ISession session = sessionFactory.OpenSession())
            {
                person = session.QueryOver<Person>().Where(x => x.Id == 1).SingleOrDefault();

                Console.WriteLine(person.FirstName+"  "+person.LastName);
                Console.WriteLine(person.City.Name);
                Console.WriteLine(person.Extra.DateOfBirth.Date.ToString("d"));
                Console.WriteLine("Telephones: ");
                foreach (Telephone t in person.Telephones)
                {
                    Console.WriteLine(t.TelephoneNumber);
                }

                Console.WriteLine("Cars: ");
                foreach (Car c in person.Cars)
                {
                    Console.WriteLine(c.Description);
                }
            }



            //Console.WriteLine("Insert ...");
            //Person p;
            //using (ISession session = sessionFactory.OpenSession())
            //{
            //    using (ITransaction transaction = session.BeginTransaction())
            //    {


            //        p = new Person { FirstName = "Aleks", LastName = "Ivanova" };
                    
            //        session.SaveOrUpdate(p);

            //        p.City = new City { Name=person.City.Name, Id=person.City.Id};
            //        p.Cars = new List<Car>();

            //        p.Extra = new Extra { DateOfBirth = DateTime.Now.Date, PersonId = p.Id };

            //        p.Telephones = new List<Telephone>();

            //        p.Telephones.Add(new Telephone { TelephoneNumber = "44-33-22" });

            //        session.SaveOrUpdate(p);

            //        transaction.Commit();
            //    }
            //}

            //Console.WriteLine("Done!");


            //Console.WriteLine("Update ...");
            //using (ISession session = sessionFactory.OpenSession())
            //{
            //    using (ITransaction transaction = session.BeginTransaction())
            //    {
            //        p.Telephones.Add(new Telephone { TelephoneNumber = "55-77-99" });

            //        session.SaveOrUpdate(p);

            //        transaction.Commit();
            //    }
            //}

            //Console.WriteLine("Done!");

            Console.WriteLine("-------------------------------------------------------------");
            using (ISession session = sessionFactory.OpenSession())
            {
                person = session.QueryOver<Person>().Where(x => x.FirstName == "Aleks").SingleOrDefault();

                Console.WriteLine(person.FirstName + "  " + person.LastName);
                Console.WriteLine(person.City.Name);

               
                Console.WriteLine(person.Extra.DateOfBirth.Date.ToString("d"));


                if (person.Telephones.Count != 0)
                {
                    Console.WriteLine("Telephones: ");
                    foreach (Telephone t in person.Telephones)
                    {
                        Console.WriteLine(t.TelephoneNumber);
                    }
                }

                else
                {
                    Console.WriteLine("This person has no telephone!");
                }


                if (person.Cars.Count!=0)
                {
                    Console.WriteLine("Cars: ");
                    foreach (Car c in person.Cars)
                    {
                        Console.WriteLine(c.Description);
                    }
                }

                else
                {
                    Console.WriteLine("This person has no car!");
                }
            }




             Console.WriteLine("-------------------------------------------------------------");
             using (ISession session = sessionFactory.OpenSession())
             {
                 using (ITransaction transaction = session.BeginTransaction())
                 {
                     Person personDelete = session.QueryOver<Person>().Where(x => x.FirstName == "Ann").SingleOrDefault();

                     session.Delete(personDelete);

                     transaction.Commit();

                 }
             }
        }
    }
}
