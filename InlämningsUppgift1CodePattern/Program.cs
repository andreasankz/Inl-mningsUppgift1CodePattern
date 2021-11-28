using Autofac;

namespace InlämningsUppgift1CodePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AutoFacConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
