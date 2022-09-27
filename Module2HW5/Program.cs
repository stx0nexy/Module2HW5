using Module2HW5.Services;
using Module2HW5.Services.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Module2HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
               .AddSingleton<ILogger, Logger>()
               .AddTransient<IFileService, FileService>()
               .AddTransient<IConfigService, ConfigService>()
               .AddTransient<INoteService, NoteService>()
               .AddTransient<Starter>()
               .BuildServiceProvider();

            var starter = serviceProvider.GetService<Starter>();
            try
            {
                starter.Run();
            }
            finally
            {
                starter.Logger.Close();
            }
        }
    }
}
