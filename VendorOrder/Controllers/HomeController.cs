using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers {
  public class HomeController : Controller {
    [Route("/")]
    public ActionResult Index() { return View(); }
    [Route("/page-name-decorator")]
    public string Hello() { return "Sup"; }
    [Route("/pagename")]
    public ActionResult PageName(string variable) {
      ClassName myVariable = new ClassName();
      myVariable.Variable = variable;
      return View(myVariable);
    }
  }
}