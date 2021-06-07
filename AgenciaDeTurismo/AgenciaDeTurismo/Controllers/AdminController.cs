using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using AgenciaDeTurismo.Db;
using AgenciaDeTurismo.Models;

namespace AgenciaDeTurismo.Controllers
{
    public class AdminController : Controller
    {
        private const string ActionDestinoListagem = "DestinoListagem"; //name of view DestinoListagem

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

        //Retorna uma instancia de DbContext
        private ViagensOnLineDb ObterDbContext()
        {
            return new ViagensOnLineDb();
        }

        //Gravar Novo Destino
        //[HttpPost]
        //public ActionResult DestinoNovo(Destino destino)
        //{
        //    //Se alguma validação falhou
        //    if (!ModelState.IsValid)
        //    {
        //        return View(destino);
        //    }

        //    //Foto é obrigatória
        //    if(Request.Files.Count == 0 || Request.Files[0].ContentLength == 0)
        //    {
        //        ModelState.AddModelError("", "É necessário enviar uma foto");
        //        return View(destino);
        //    }

        //    //Grava
        //    destino.Foto = GravarFoto(Request);
        //}
    }
}