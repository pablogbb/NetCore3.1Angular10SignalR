using Models;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.DbContext;

namespace DAL
{
    public class PqrRepository
    {
        private IDbContext dbContext;
        public PqrRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
    }
}
