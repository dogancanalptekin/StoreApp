using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entity;

namespace StoreApp.Data.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
        Task<int> SaveCategoryAsync(Category entity);
        Task<Category> DeleteCategoryAsync(int id);
    }
}
