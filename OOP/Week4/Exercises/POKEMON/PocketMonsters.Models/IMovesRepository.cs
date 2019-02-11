using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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