using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimerParcialAP2.Models;
using PrimerParcialAP2.DAL;
using Microsoft.EntityFrameworkCore;

namespace PrimerParcialAP2.Controllers
{
    public class ArticulosController
    {
        public bool Guardar(Articulos entity)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Articulos.Add(entity);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public bool Modificar(Articulos entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                Articulos articulo = db.Articulos.Find(Id);
                db.Entry(articulo).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public Articulos Buscar(int Id)
        {
            Articulos articulo;
            Contexto db = new Contexto();
            try
            {
                articulo = db.Articulos.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
            return articulo;
        }


    }
}
