using Parcial1_LindonCastillo.DAL;
using Parcial1_LindonCastillo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_LindonCastillo.BLL
{
    public class ProductosBLL
    {   
        public static bool Guardar(Productos Producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if(db.Producto.Add(Producto)!= null)
                {
                    paso = db.SaveChanges() > 0;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Productos Producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = Buscar(Producto.ProductoId);
                foreach(var item in Anterior.Precio)
                {
                    if (!Producto.Precio.Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }

                db.Entry(Producto).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Producto.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static Productos Buscar(int id)
        {
            Contexto db = new Contexto();
            Productos Producto;

            try
            {
                Producto =  db.Producto.Find(id);
                Producto.Precio.Count();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Producto;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> Producto)
        {
            List<Productos> Lista = new List<Productos>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Producto.Where(Producto).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Lista;
        }
    }
}
