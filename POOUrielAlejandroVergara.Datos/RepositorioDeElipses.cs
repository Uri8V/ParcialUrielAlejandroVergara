using POOUrielAlejandroVergara.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUrielAlejandroVergara.Datos
{
    public class RepositorioDeElipses
    {
        private List<Elipses> listaElipses;
        private bool hayCambios = false;
        public RepositorioDeElipses()
        {
            listaElipses = new List<Elipses>();
           // listaElipses = ManejadorDeArchivoSecuencial.LeerArchivo();
        }
        public void Agregar(Elipses elipses)
        {
            listaElipses.Add(elipses);
            hayCambios = true;
        }

        public int GetCantidad()
        {
            return listaElipses.Count();
        }

        public List<Elipses> getLista()
        {
            return listaElipses;
        }

        public bool ExisteElipse(Elipses el)
        {
            return listaElipses.Any(e => e.SemiEjeMayor == e.SemiEjeMayor && e.SemiEjeMenor == e.SemiEjeMenor);
        }

        public bool Borrar(Elipses elipses)
        {
            if (listaElipses.Contains(elipses))
            {
                listaElipses.Remove(elipses);
                hayCambios = true;
                return true;
            }
            return false;
        }

        public void Editar()
        {
            hayCambios = true;
        }

        public void Guardar()
        {
            if (hayCambios)
            {
                //ManejadorDeArchivoSecuencial.GuardarEnArchivoSecuencial(listaElipses);
            }
        }

        public List<Elipses> GetLista()
        {
            return listaElipses;
        }
    }
}
