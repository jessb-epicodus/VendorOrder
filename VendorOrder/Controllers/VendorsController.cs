using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers {
  public class Vendor : Controller {
    [Route("/")]  // root directory path
    public ActionResult Index() { return View(); }
  }
}