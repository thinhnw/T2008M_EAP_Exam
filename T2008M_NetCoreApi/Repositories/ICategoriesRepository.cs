using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2008M_NetCoreApi.Models;

namespace T2008M_NetCoreApi.Repositories
{
    public interface ICategoriesRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(Category category);
        Task SaveChangesAsync();
        
    }
}
