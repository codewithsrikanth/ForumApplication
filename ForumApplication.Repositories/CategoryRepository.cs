using ForumApplication.DataModels;
using System.Collections.Generic;

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
    public class CategoryRepository
    {
        public void DeleteCategory(int cid)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new System.NotImplementedException();
        }

        public Category GetCategoryByCategoryID(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public void InsertCategory(Category c)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCategory(Category c)
        {
            throw new System.NotImplementedException();
        }
    }
}
