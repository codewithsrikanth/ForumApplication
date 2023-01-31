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
    public class CategoryService
    {
    }
}
