using System.Collections.Generic;
using Domain;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Tool.hbm2ddl;
using TypeInfo = Domain.TypeInfo;

namespace Infrastructure
{
    public class DbHelper
    {
        private static ISessionFactory sessions;

        public static void Configure()
        {
            sessions = new Configuration().Configure().
                AddClass(typeof (Abonent)).
                AddClass(typeof (TypeInfo)).
                AddClass(typeof (Phone)).
                BuildSessionFactory();
        }

        public static void CreateTables()
        {
            //для данной процедуры создание сессии
            //не нужно, поэтому здесь мы будем отдельно
            //конфигурировать подключение к БД
            Configuration configuration = new Configuration();
            configuration.Configure();
            configuration.AddClass(typeof(Abonent));
            configuration.AddClass(typeof(TypeInfo));
            configuration.AddClass(typeof(Phone));
            //создаем объект типа SchemaExport на основе созданной
            //ранее конфигурации. Данный объект нужен для экспорта схемы БД
            //либо в скрипт, либо непосредственно в БД
            SchemaExport schemaExport = new SchemaExport(configuration);
            //выполняем экспорт.
            //1-й параметр-нужно ли выносить код создания таблиц
            //в какой-то файл. Нам это не надо, поэтому стоит false
            //2-й параметр- нужно ли делать экспорт схемы в БД.Нам экспорт нужен-true
            //3-й параметр-использовать конструкции drop в создаваемом скрипте.
            //Т.е. нужен ли drop table перед create table
            schemaExport.Execute(false, true, false);
        }

        // <summary>
        // Заносим новый контакт в тел. книжку
        // </summary>
        // <param name="pb">Объект-контакт, который добавляем в тел.книгу</param>
        public static void InsertContact(Phone pb)
        {
            //Открываем новую сессию
            using (ISession session = sessions.OpenSession())
            //Начинаем транзакцию
            using (ITransaction tx = session.BeginTransaction())
            {
                //Сохраняем информацию о новом контакте
                session.Save(pb);
                //Подтверждаем транзакцию
                tx.Commit();
            }
        }
        // <summary>
        //Обновляем контакт в тел. книжке
        // </summary>        
        public static void UpdateContact(Phone pb)
        {
            using (ISession session = sessions.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Update(pb);
                tx.Commit();
            }
        }
        // <summary>
        // Удаляем контакт из тел.книжки
        // </summary>
        // <param name="pb"></param>
        public static void DeleteContact(Phone pb)
        {
            using (ISession session = sessions.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Delete(pb);
                tx.Commit();
            }
        }





        // <summary>
        // Находим список абонентов, у которых в 
        // ФИО встречается строка FIO
        // </summary>
        // <param name="FIO"></param>
        // <returns>Возвращаем список абонентов</returns>
        public static IList<Abonent> FindAbonent(string FIO)
        {
            //Открываем новую сессию
            using (ISession sess = sessions.OpenSession())
            {
                //возвращаем результат выборки
                return sess
                    //создаем критерий для абонентов
                    .CreateCriteria(typeof(Abonent))
                    //добавляем выражение:
                    //поиск по полю FIO,что аналогично запросу
                    //where FIO like '%FIO%'
                    .Add(Expression.Like("FIO", "%" + FIO + "%"))
                    //возвращаем список объектов типа Abonent
                    .List<Abonent>();
            }
        }

        public static IList<Abonent>AllAbonent()
        {
            //Открываем новую сессию
            using (ISession sess = sessions.OpenSession())
            {
                //возвращаем результат выборки
                return sess
                    //создаем критерий для абонентов
                    .CreateCriteria(typeof(Abonent))
                    //возвращаем список объектов типа Abonent
                    .List<Abonent>();
            }
        }

        // <summary>
        // Поиск по связным таблицам Abonents и Contacts.
        // Будем искать записи из
        // телефонной книги, у которых строка из столбца
        // FIO(таблица Abonents) содержит подстроку FIO,
        // а значение Value (таблица Contacts) 
        // подстроку Value
        // </summary>
        // <param name="FIO"></param>
        // <param name="Value"></param>
        // <returns>
        // Возвращаем список объектов Phone,
        // удовлетворяющих заданным условияем
        // </returns>
        public static IList<Phone> FindContacts(string FIO, string Value)
        {
            //открываем новую сессию
            using (ISession sess = sessions.OpenSession())
            {
                //создаем критерий для главного класса Phone
                return sess.CreateCriteria(typeof(Phone))
                    //добавляем выражением, SQL-аналог
                    //where Value like '%Value%'
                                .Add(Expression.Like("Value", "%" + Value + "%"))
                    //добавляем критерий для свойства abon
                    //класса Phone
                                .CreateCriteria("abon")
                    //добавляем выражение для поиска по полю FIO
                                .Add(Expression.Like("FIO", "%" + FIO + "%"))
                    //возвращаем список объектов Phone
                                .List<Phone>();
            }
        }
    }
}
