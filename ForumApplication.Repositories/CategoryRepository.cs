using ForumApplication.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace ForumApplication.Repositories
{
    public interface ICategoryRepository
    {
        void InsertCategory(Category c);
        void UpdateCategory(Category c);
        void DeleteCategory(int cid);
        List<Category> GetCategories();
        Category GetCategoryByCategoryID(int categoryId);
    }
    public class CategoryRepository:ICategoryRepository
    {        
        private ForumAppDbContext _dbContext;
        public CategoryRepository()
        {
            _dbContext = new ForumAppDbContext();
        }

        public void DeleteCategory(int cid)
        {
            var category = _dbContext.Categories.Find(cid);
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetCategoryByCategoryID(int categoryId)
        {
            return _dbContext.Categories.Find(categoryId);
        }

        public void InsertCategory(Category c)
        {
            _dbContext.Categories.Add(c);
            _dbContext.SaveChanges();
        }

        public void UpdateCategory(Category c)
        {
            _dbContext.Entry(c).State = System.Data.Entity.EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
