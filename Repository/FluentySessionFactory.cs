using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Repository
{
    public class FluentySessionFactory
    {

        /// <summary>
        /// Фабрика сессий
        /// </summary>
        private readonly ISessionFactory _sessionFactory;

        /// <summary>
        /// Конструктор, инициализирует объект <see cref="NHibernateConfiguration"/> класса
        /// </summary>
        public FluentySessionFactory()
        {
            _sessionFactory = Fluently.Configure().Database(PostgreSQLConfiguration.Standard
                .ConnectionString(c => c
                    .Host("localhost")
                    .Port(5432)
                    .Database("travel")
                    .Username("postgres")
                    .Password("postgres")))
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapping.ClientMap>()).BuildSessionFactory();
        }

        /// <summary>
        /// Получить сессию
        /// </summary>
        public ISession Session => _sessionFactory.OpenSession();
    }

}
