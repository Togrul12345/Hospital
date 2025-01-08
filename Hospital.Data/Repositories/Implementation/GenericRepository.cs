using Hospital.Core.Entities;
using Hospital.Data.Contexts;
using Hospital.Data.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repositories.Implementation
{
    public class GenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity : BaseEntity, new()
    {
        private readonly HospitalApiDbContext _hospitalApiDbContext;

        public GenericRepository(HospitalApiDbContext hospitalApiDbContext)
        {
            _hospitalApiDbContext = hospitalApiDbContext; ;
        }
        public DbSet<Tentity> Table => _hospitalApiDbContext.Set<Tentity>();

        public async Task<Tentity> CreateAsync(Tentity tentity)
        {
            await Table.AddAsync(tentity);
            return tentity;
        }

        public async Task<List<Tentity>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<Tentity> GetByIdAsync(int id)
        {
            var result = await Table.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
            if (result == null)
            {
                throw new Exception("Something went wrong");
            }
            return result;
        }

        public async Task HardDeleteAsync(int id)
        {
            var result = await GetByIdAsync(id);
            Table.Remove(result);

        }

        public async Task<int> SaveChangesAsync()
        {
            return await _hospitalApiDbContext.SaveChangesAsync();
        }

        public async Task SoftDeleteAsync(int id)
        {
            var result = await GetByIdAsync(id);
            result.CreatedAt = DateTime.Now;
            await SaveChangesAsync();

        }

        public async void Update(Tentity tentity)
        {

            Table.Update(tentity);
        }
    
    }
}
