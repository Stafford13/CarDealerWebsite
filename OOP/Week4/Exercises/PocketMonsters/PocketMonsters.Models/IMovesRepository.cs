using System.Collections.Generic;


namespace PocketMonsters.Models
{
    public interface IMovesRepository
    {
        Moves Create(Moves pokemon);
        void Delete(int id);
        List<Moves> ReadAll();
        Moves ReadById(int id);
        void Update(int id, Moves newMovesInfo);
    }
}