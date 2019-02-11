using System;
using PocketMonsters.Models;

namespace PocketMonsters.BLL
{
    public class PokeManager
    {
        private IPokemonRepository repo;
        private IUserIO io;
        public PokeManager(IUserIO io, IPokemonRepository repo)
        {
            this.repo = repo;
            this.io = io;
        }
        public void Run()
        {
            bool keepRunning = true;
            int menuChoice = 0;

            while (keepRunning == true)
            {
                menuChoice = io.GetOptions("1.) Readall\n2.) Create 3.) Exit", 1, 3);
                switch (menuChoice)
                {
                    case 1:
                        this.ListAllPokemon();
                        break;
                    case 2:
                        CreatePokemon();
                        break;
                    case 3:
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
                io.PrintMessagerClear("Please press Continue");

            }

            //// Read ALL
            //ListAllPokemon();
            //Console.ReadLine();
            //Console.Clear();

            //// Create

            //CreatePokemon();
            //// Read By Id

            //ReadPokemonById();

            ////Delete Pokemon
            //DeletePokemon();






        }

        private void ListAllPokemon()
        {
            io.PrintPokemon(repo.ReadAll());
        }

        private void ReadPokemonById()
        {
            Pokemon pokemonInfo = repo.ReadById(io.PromptUserForInt("Enter Id"));
            pokemonInfo.Name = "Bob";


            if (pokemonInfo != null)
            {
                io.DisplayPokemon(pokemonInfo);
                // Update Character
                UpdatePokemon(pokemonInfo);
            }
        }

        private void UpdatePokemon(Pokemon pokemonInfo)
        {
            string name = io.PromptUser("Please Enter a name");
            pokemonInfo.Name = name;
            repo.Update(pokemonInfo.Id, pokemonInfo);
            Console.Clear();
            io.DisplayPokemon(repo.ReadById(pokemonInfo.Id));
        }

        private void CreatePokemon()
        {
            Pokemon newPokemon = io.PromptUserForNewPokemon();

            newPokemon = repo.Create(newPokemon);

            io.DisplayPokemon(repo.ReadById(newPokemon.Id));
        }

        private void DeletePokemon()
        {
            int id = io.PromptUserForInt("Enter Id to remove");
            repo.Delete(id);
            Pokemon deletedInfo = repo.ReadById(io.PromptUserForInt("Enter Id for pokemon"));
            if (deletedInfo == null)
            {
                Console.WriteLine("No pokemon found");
            }
        }