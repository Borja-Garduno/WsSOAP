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
            IList<Usuario> usuarios = service.getAllNoBorrados();
            return View(usuarios);
        }

        public void Delete(int codUsuario) {
            service.delete(codUsuario);
        }

        public Usuario Create(Usuario usuario) {
            return service.create(usuario);
        }

        public Usuario Update(Usuario usuario) {
            return service.update(usuario);
        }
    }
}