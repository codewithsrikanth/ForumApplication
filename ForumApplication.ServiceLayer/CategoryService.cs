using ForumApplication.DataModels;
using ForumApplication.ViewModels;
using System.Collections.Generic;

namespace ForumApplication.ServiceLayer
{
    public interface ICategoryService
    {
        void InsertCategory(CategoryViewModel c);
        void UpdateCategory(CategoryViewModel c);
        void DeleteCategory(int cid);
        List<CategoryViewModel> GetCategories();
        CategoryViewModel GetCategoryByCategoryID(int categoryId);
    }
    public class CategoryService : ICategoryService
    {
        public void DeleteCategory(int cid)
        {
            throw new System.NotImplementedException();
        }

        public List<CategoryViewModel> GetCategories()
        {
            throw new System.NotImplementedException();
        }

        public CategoryViewModel GetCategoryByCategoryID(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public void InsertCategory(CategoryViewModel c)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCategory(CategoryViewModel c)
        {
            throw new System.NotImplementedException();
        }
    }
}
