using Hospital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repositories.Abstraction
{
    public interface IGenericRepository<Tentity> where Tentity : BaseEntity,new()
    {
        Task<Tentity> CreateAsync(Tentity tentity);
        Task<List<Tentity>> GetAllAsync();
        Task<Tentity> GetByIdAsync(int id);
        void Update(Tentity tentity);
        Task SoftDeleteAsync(int id);
        Task HardDeleteAsync(int id);
        Task<int> SaveChangesAsync();
        
    
    }
}
