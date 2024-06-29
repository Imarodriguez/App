

using App.Data.Entities;

namespace App.Data.Interfaces
{
    public class IDaoCategory
    {
        List<Category> GetCategories();

        Category GetCategory(int Id);

        void SaveCategory(Category category);

        void UpdateCategory(Category category);

        void RemoveCategory(Category category);
    }
}
