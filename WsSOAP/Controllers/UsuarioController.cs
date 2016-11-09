using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WsSOAP.SOAPService;

namespace WsSOAP.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            
            SOAPService.UsuarioClient service = new SOAPService.UsuarioClient();
            IList<Usuario> usuarios = service.getAll();


            return View(usuarios);
        }
    }
}