
namespace Serene.AdminLTE
{
    using Serenity.Web;
#if ASPNETCORE
    using Microsoft.AspNetCore.Mvc;
#else
    using System.Web.Mvc;
#endif

    [PageAuthorize, Route("AdminLTE/Tables/{action=index}")]
    public class TablesController : Controller
    {
        public ActionResult SimpleTables()
        {
            return View(MVC.Views.AdminLTE.Tables.SimpleTables);
        }
    }
}
