using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WsSOAP.BBLL.interfaces;

namespace WsSOAP.api {

    public class UsuariosController : ApiController
    {
        private UsuarioService uS;
        public UsuariosController()
        {
            uS = new UsuarioServiceImp();
        }
        // GET api/<controller>
        public HttpResponseMessage GetAll()
        {
            IList<Usuario> usuarios = uS.getAll();
            var response = Request.CreateResponse<IList<Usuario>>(System.Net.HttpStatusCode.OK, usuarios);
            return response;
        }

        // GET api/<controller>/5
        public HttpResponseMessage GetById(int id)
        {
            IList<Usuario> ejemplares = uS.getListById(id);
            HttpResponseMessage response;
            if (ejemplares != null)
            {
                response  = Request.CreateResponse<IList<Usuario>>(System.Net.HttpStatusCode.OK, ejemplares);
            }else
            {
                response = Request.CreateResponse(System.Net.HttpStatusCode.NotFound);
            }
            
            return response;
        }

        // POST api/<controller>
        public HttpResponseMessage Post(Usuario usuario)
        {
            uS.create(ejemplar);
            return Request.CreateResponse(System.Net.HttpStatusCode.Created);
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(Usuario usuario)
        {
            uS.update(usuario);
            return Request.CreateResponse<Usuario>(System.Net.HttpStatusCode.OK,usuario);
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK);
        }
    }
}