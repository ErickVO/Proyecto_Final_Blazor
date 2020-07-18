using System;
using System.Collections.Generic;
using System.Text;
using StudioEF.Models;
using Microsoft.EntityFrameworkCore;
using StudioEF.DAL;
using System.Linq;
using System.Linq.Expressions;

namespace StudioEF.BLL
{
    public class FotografosBLL
    {
        public static bool Guardar(Fotografos fotografos)
        {
            if (!Existe(fotografos.FotografoId))
            {
                return Insertar(fotografos);
            }
            else
            {
                return Modificar(fotografos);
            }

        }

        public static bool Insertar(Fotografos fotografo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Fotografos.Add(fotografo) != null)
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

        public static bool Modificar(Fotografos fotografo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(fotografo).State = EntityState.Modified;
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

        private static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = db.Fotografos.Any(d => d.FotografoId == id);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Fotografos.Find(id);
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

        public static Fotografos Buscar(int id)
        {
            Fotografos fotografo = new Fotografos();
            Contexto db = new Contexto();

            try
            {
                fotografo = db.Fotografos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return fotografo;
        }

        public static List<Fotografos> GetList(Expression<Func<Fotografos, bool>> fotografo)
        {
            List<Fotografos> Lista = new List<Fotografos>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Fotografos.Where(fotografo).ToList();
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
