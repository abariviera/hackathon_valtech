using Glass.Mapper.Sc.Web.Mvc;
using OneValtech.Feature.BasicComponents.Models.FeaturedValtechie;
using System.Web.Mvc;

namespace OneValtech.Feature.BasicComponents.Controllers.FeaturedValtechie
{
    public class FeaturedValtechieController : Controller
    {
        private readonly IMvcContext _mvcContext;

        public FeaturedValtechieController()
        {
            _mvcContext = new MvcContext();
        }

        public ActionResult Index()
        {
            var model = _mvcContext.GetDataSourceItem<IFeaturedValtechie>();
            return View("~/Views/FeaturedValtechie/FeaturedValtechie.cshtml", model);
        }
    }
}