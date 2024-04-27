using DominioTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioTp
{ 

    public class NegocioImagen
        {
            public List<Imagen> Listar()
            {
                List<Imagen> lista = new List<Imagen>();
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta("select Id, IdArticulo, ImagenUrl from IMAGENES");
                    datos.EjecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Imagen aux = new Imagen();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];

                        lista.Add(aux);
                    }
                    return lista;
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

            public void AgregarNuevaIma(Imagen nuevo)
            {
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta("insert into IMAGENES (IdArticulo, ImagenUrl) values ('"+nuevo.IdArticulo+"','"+nuevo.UrlImagen+"')");
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
        
    }
}

