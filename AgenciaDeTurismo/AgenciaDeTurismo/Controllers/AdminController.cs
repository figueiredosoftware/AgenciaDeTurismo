using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace AgenciaDeTurismo.Controllers
{
    public class AdminController : Controller
    {
        private const string ActionDestinoListagem = "DestinoListagem";

        //Incluir Destino
        [HttpGet]
        public ActionResult DestinoNovo()
        {
            return View();
        }

        //Gravar Foto
        private string GravarFoto(HttpRequestBase Request)
        {
            string nome = Path.GetFileName(Request.Files[0].FileName);
            string pastaVirtual = "~/Imagens";
            string pathVirtual = pastaVirtual + "/" + nome;
            string pathFisico = Request.MapPath(pastaVirtual);
            Request.Files[0].SaveAs(pathFisico);

            return nome;
        }
    }
}