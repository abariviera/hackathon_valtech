using Glass.Mapper.Sc.Web.Mvc;
using OneValtech.Feature.BasicComponents.Models.NavigationMenu;
using System.Web.Mvc;

namespace OneValtech.Feature.BasicComponents.Controllers.NavigationMenu
{
    public class NavigationMenuController : Controller
    {
        private readonly IMvcContext _mvcContext;

        public NavigationMenuController()
        {
            _mvcContext = new MvcContext();
        }

        public ActionResult Index()
        {
            var model = _mvcContext.GetDataSourceItem<INavigationMenu>();
            return View("~/Views/NavigationMenu/NavigationMenu.cshtml", model);
        }
    }
}