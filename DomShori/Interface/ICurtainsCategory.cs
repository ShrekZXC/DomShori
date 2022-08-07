using DomShori.Models;

namespace DomShori.Interface
{
    public interface ICurtainsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
