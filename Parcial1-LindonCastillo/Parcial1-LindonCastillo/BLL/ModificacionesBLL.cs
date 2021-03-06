﻿using Parcial1_LindonCastillo.DAL;
using Parcial1_LindonCastillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_LindonCastillo.BLL
{
    class ModificacionesBLL
    {
        public static bool Guardar(Modificaciones Modificacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Modificacion.Add(Modificacion) != null)
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

        public static List<Modificaciones> GetList(Expression<Func<Modificaciones, bool>> Modificacion)
        {
            List<Modificaciones> Lista = new List<Modificaciones>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Modificacion.Where(Modificacion).ToList();
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
