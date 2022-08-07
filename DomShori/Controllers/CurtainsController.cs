using DomShori.Interface;
using DomShori.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DomShori.Controllers
{
    public class CurtainsController : Controller
    {
        private readonly IAllCurtains _allCurtains;
        private readonly ICurtainsCategory _curtainsCategory;

        public CurtainsController(IAllCurtains iAllCurtains, ICurtainsCategory iCurtainsCategory)
        {
            _allCurtains = iAllCurtains;
            _curtainsCategory = iCurtainsCategory;


        }

        public ViewResult ListCurtains()
        {
            ViewBag.Titel = "Дом Штор";
            CurtainsListViewModel obj = new CurtainsListViewModel();
            obj.AllCurtains = _allCurtains.curtains;
            obj.currCategory = "Шторы";
            return View(obj);
        }


    }
}
