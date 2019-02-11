using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketMonsters.Models;

namespace PocketMonsters.Services
{
    public class PokemonService : IPokemonService
    {
        private IPokemonRepository _pokemonRepository;
        private IMovesRepository _movesRepository;

        public PokemonService(IPokemonRepository pokemonRepository, IMovesRepository movesRepository)
        {
            _pokemonRepository = pokemonRepository;
            _movesRepository = movesRepository;
        }
        // ADD CRUD Functionality for service
        public Pokemon CreatePokemon(Pokemon pokemon)
        {
            // RULES:
            // 1.) Must have a name
            // 2.) Pokemon can not start with more than 100 health
            return _pokemonRepository.Create(pokemon);
        }

        public List<Pokemon> ReadAllPokemons()
        {
            return _pokemonRepository.ReadAll();
        }

        public Pokemon ReadByPokemonId(int pokemonId)
        {
            Pokemon pokemon = _pokemonRepository.ReadById(pokemonId);
            pokemon.Movess = _movesRepository.ReadByPokemonId(pokemonId);
            return pokemon;
        }

        public void UpdatePokemon(Pokemon pokemon)
        {
            _pokemonRepository.Update(pokemon.Id, pokemon);
        }

        public void DeletePokemon(int id)
        {
            _pokemonRepository.Delete(id);
        }

        public List<Moves> RetrieveAvailableMovess()
        {
            var query = from moves in _movesRepository.ReadAll()
                        where moves.PokemonId.HasValue == false
                        select moves;
            if (!query.Any()) throw new NoMovesAvailableException("No movess available");
            return query.ToList();

        }

        public void BuyMoves(int pokemonId, int movesId)
        {
            // TODO: Pokemon Buys an moves
            // RULES:
            //0) Is the moves already owned?
            Moves moves = _movesRepository.ReadById(movesId);
            Pokemon pokemon = this.ReadByPokemonId(pokemonId);
            if (moves.PokemonId.HasValue) throw new Exception("This moves is already owned");
            //1) You must have gold to buy moves
            if (pokemon.Gold < moves.Cost) throw new Exception("You be broke! Arghh!");
            //2) YOu can carry 3 movess
            if (pokemon.Movess.Count() >= 3) throw new Exception("You can not buy any more movess");
            //3) You can only buy 1 moves type by pokemon
            if (pokemon.Movess.Any(i => i.Name == moves.Name)) throw new Exception("You already have this moves");


            // if you have reached this point, you may update the moves, and pokemon.
            pokemon.Gold -= moves.Cost;
            moves.PokemonId = pokemon.Id;

            // Must update the Moves Repository when a change needs to be stored
            _movesRepository.Update(movesId, moves);
            _pokemonRepository.Update(pokemonId, pokemon);



        }
        public void SellMoves(int pokemonId, int movesId, decimal amount)
        {
            // TODO: Pokemon Buys an moves
            // RULES:
            //0) Is the moves already owned?
            Moves moves = _movesRepository.ReadById(movesId);
            Pokemon pokemon = this.ReadByPokemonId(pokemonId);

            if (moves.PokemonId != pokemonId) throw new Exception("This moves is not owned by you!");
            //1) You must have gold to buy moves
            if (amount > moves.Cost * 1.5m) throw new Exception("That be too much");



            // if you have reached this point, you may update the moves, and pokemon.
            pokemon.Gold += amount;
            moves.PokemonId = null;

            // Must update the Moves Repository when a change needs to be stored
            _movesRepository.Update(movesId, moves);
            _pokemonRepository.Update(pokemonId, pokemon);



        }
        // Add to ListAll Movess
        // TODO: Pokemon Sells an Moves
    }
}
