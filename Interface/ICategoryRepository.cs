using ReviewApp.Models;

namespace ReviewApp.Interface
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonsByCategory(int categoryId);
        bool CategoryExists(int id);
        bool createCategory(Category category);
        bool UpdateCategory(Category category);

        bool DeleteCategory(Category category);
        bool save();
    }
}
