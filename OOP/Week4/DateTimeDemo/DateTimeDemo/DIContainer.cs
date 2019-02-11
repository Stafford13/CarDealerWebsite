using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Data;
using DateTimeDemo.Models;
using DateTimeDemo.Services;
using DateTimeDemo.UI;
using Ninject;

namespace DateTimeDemo
{
    public static class DIContainer
    {
        // the kernel is the master factory
        public static IKernel Kernel = new StandardKernel();

        static DIContainer()
        {
            string setting = ConfigurationManager.AppSettings["someSetting"];
            switch (setting)
            {
                case "bob":
                    Kernel.Bind<ICharacterRepository>().To<FileCharacterRepository>().WithConstructorArgument("Characters.txt");      
                    break;
                case "list":
                    Kernel.Bind<ICharacterRepository>().To<ListCharacterRepository>();      
                    break;
                default:
                    Kernel.Bind<ICharacterRepository>().To<ListCharacterRepository>();      
                    break;
            }
            Kernel.Bind<IUserIO>().To<UserIO>();
            Kernel.Bind<IItemRepository>().To<FileItemRespository>().WithConstructorArgument("Items.txt");
            Kernel.Bind<ICharacterService>().To<CharacterService>();
        }
    }
}
