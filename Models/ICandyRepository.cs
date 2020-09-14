using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyWorld.Models
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> Search(string SearchByCandy);
        IEnumerable<Candy> GetAllCandy { get; }
        IEnumerable<Candy> GetCandyOnSale { get; }
        Candy GetCandyById(int candyId);
    }
}
