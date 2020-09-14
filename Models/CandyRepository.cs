using CandyWorld.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyWorld.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CandyRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Candy> GetAllCandy
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category);
            }
        }

        public IEnumerable<Candy> GetCandyOnSale
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Candy GetCandyById(int candyId)
        {
            return _appDbContext.Candies.FirstOrDefault(c => c.CandyId == candyId);
        }

        public IEnumerable<Candy> Search(string SearchByCandy)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Candy> Search(string SearchByCandy)
        //{
        //    if(string.IsNullOrEmpty(SearchByCandy))
        //    {
        //        return _appDbContext.Candies.Include(c => c.Category);
        //    }
        //    return _appDbContext.Candies.Where(e => e.Name.Contains(SearchByCandy));
        //}
    }
}

