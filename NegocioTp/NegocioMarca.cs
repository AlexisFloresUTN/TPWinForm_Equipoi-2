using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominioTp;
using NegocioTp;

namespace NegocioTp
{
    public class NegocioMarca
    {
        public List<Marca> ListarMarcas()
        {
            List<Marca> ListaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    ListaMarcas.Add(aux);
                }

                return ListaMarcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void AgregarNuevaMarca(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into MARCAS (Descripcion)values('"+nuevo.Descripcion +"')");
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
        public void EliminarMarca(int idMarca)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from MARCAS where Id = @id");
                datos.setearParametro("@id", idMarca);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
