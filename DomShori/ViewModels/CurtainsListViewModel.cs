using DomShori.Models;

namespace DomShori.ViewModels
{
    public class CurtainsListViewModel
    {
        public IEnumerable<Curtain> AllCurtains { get; set; }

        public string currCategory { get; set; }

    }
}
