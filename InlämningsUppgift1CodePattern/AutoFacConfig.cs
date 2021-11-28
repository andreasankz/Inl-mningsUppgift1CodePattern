using Autofac;
using System.Linq;
using System.Reflection;

namespace InlämningsUppgift1CodePattern
{
    public class AutoFacConfig
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
               .Where(x => x.Namespace.Contains("Menu"))
               .As(x => x.GetInterfaces()
               .FirstOrDefault(i => i.Name == "I" + x.Name))
               .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
               .Where(x => x.Namespace.Contains("Kennel"))
               .As(x => x.GetInterfaces()
               .FirstOrDefault(i => i.Name == "I" + x.Name))
               .AsImplementedInterfaces();


            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
               .Where(x => x.Namespace.Contains("Customer"))
               .As(x => x.GetInterfaces()
               .FirstOrDefault(i => i.Name == "I" + x.Name))
               .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(x => x.Namespace.Contains("Animal"))
              .As(x => x.GetInterfaces()
              .FirstOrDefault(i => i.Name == "I" + x.Name))
              .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
