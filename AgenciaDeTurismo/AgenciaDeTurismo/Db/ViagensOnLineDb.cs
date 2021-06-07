using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgenciaDeTurismo.Models;
using System.Data.Entity;


namespace AgenciaDeTurismo.Db
{
    public class ViagensOnLineDb:DbContext
    {
        private const string conexao = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Alessandro\Projetos\Projetos Versionados\AgenciaDeTurismo\AgenciaDeTurismo\AgenciaDeTurismo\App_Data\ViagensOnLineDb.mdf';Integrated Security = True";

        public ViagensOnLineDb() : base(conexao) 
        {
            
        }

        public DbSet<Destino> Destinos { get; set; }
    }
}