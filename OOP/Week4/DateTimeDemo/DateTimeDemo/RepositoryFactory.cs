using System.Configuration;
using DateTimeDemo.Data;
using DateTimeDemo.Models;
using DateTimeDemo.Services;
using DateTimeDemo.UI;

namespace DateTimeDemo
{
    public class RepositoryFactory
    {
        public static ICharacterRepository GetNewCharacterRepository()
        {
            ICharacterRepository repo = null;
            string setting = ConfigurationManager.AppSettings["someSetting"];
            switch (setting)
            {
                case "bob":
                    repo = new FileCharacterRepository("Characters.txt");
                    break;
                case "list":
                    repo = new ListCharacterRepository();
                    break;
                default:
                    repo = new ListCharacterRepository();
                    break;
            }
            return repo;
        }
        public static IItemRepository GetNewItemRepository()
        {
            IItemRepository repo = new FileItemRespository("Items.txt");
           
            return repo;
        }

        public static CharacterManager Create()
        {
            IUserIO io = new UserIO();

            ICharacterRepository repo;
            IItemRepository itemRepo;
            ICharacterService service;

            repo = GetNewCharacterRepository();
            itemRepo = GetNewItemRepository();
            service = new CharacterService(repo, itemRepo);

            CharacterManager manager = new CharacterManager(io, service);

            return manager;
        }

      
    }
}