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
        SOAPService.UsuarioClient service = new SOAPService.UsuarioClient();

        // GET: Usuario
        public ActionResult Index()
        {
            IList<Usuario> usuarios = service.getAll();
            return View(usuarios);
        }

        public void Delete(int codUsuario) {
            service.delete(codUsuario);
        }
    }
}