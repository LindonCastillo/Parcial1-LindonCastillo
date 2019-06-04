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
    public class UbicacionesBLL
    {
        public static bool Guardar(Ubicaciones Ubicacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Ubicacion.Add(Ubicacion) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Ubicaciones Ubicacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(Ubicacion).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
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
                var eliminar = db.Ubicacion.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static Ubicaciones Buscar(int id)
        {
            Ubicaciones Ubicacion;
            Contexto db = new Contexto();

            try
            {
                Ubicacion = db.Ubicacion.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Ubicacion;
        }

        public static List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> Ubicacion)
        {
            List<Ubicaciones> Lista = new List<Ubicaciones>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Ubicacion.Where(Ubicacion).ToList();
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
