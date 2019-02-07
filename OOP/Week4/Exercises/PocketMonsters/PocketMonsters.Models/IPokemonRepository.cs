using System.Collections.Generic;


namespace PocketMonsters.Models
{
    public interface IPokemonRepository
    {
        Pokemon Create(Pokemon pokemon);
        void Delete(int id);
        List<Pokemon> ReadAll();
        Pokemon ReadById(int id);
        void Update(int id, Pokemon newPokemonInfo);
    }
}