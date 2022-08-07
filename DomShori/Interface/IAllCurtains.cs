using DomShori.Models;

namespace DomShori.Interface
{
    public interface IAllCurtains
    {
        IEnumerable<Curtain> curtains { get; }
        IEnumerable<Curtain> getFavCurtains { get; set; }

        Curtain GetObjCurtain(int curtainId);

    }
}
