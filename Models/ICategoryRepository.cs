using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyWorld.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
