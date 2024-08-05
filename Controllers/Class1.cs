using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DataBase;

namespace Controllers
{
    public class Controler
    {
        //metodo traer todos los elementos
        public  List<Articulos> listar() {

            List<Articulos> ListaArticulo = new List<Articulos>(); 

            Data data = new Data();

            
            
            try
            {
                
                data.setearConsulta("select A.Id as Id,A.Codigo as Codigo,Nombre, A.Descripcion Descripcion,C.Descripcion as Categoria, M.Descripcion as MarcaDes,Precio,A.ImagenUrl from ARTICULOS A, MARCAS M,CATEGORIAS C where A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                data.ejecutarConsulta();

                while (data.LectorReader.Read())

                {
                    Categoria categoria = new Categoria();
                    Marca marca = new Marca();
                    
                    Articulos newArticulo = new Articulos(categoria,marca);

                    //validacion de NULL
                    if (!(data.LectorReader["Codigo"] is DBNull))
                    newArticulo.Codigo = (string)data.LectorReader["Codigo"];

                    newArticulo.Id = (int)data.LectorReader["Id"];
                    newArticulo.Nombre = (string)data.LectorReader["Nombre"];
                    newArticulo.Descripcion = (string)data.LectorReader["Descripcion"];
                    marca.Marcas = (string)data.LectorReader["MarcaDes"];
                    newArticulo.Imagen = (string)data.LectorReader["ImagenUrl"];
                    //Utilizamos el metodo de la clase string (TrimEnd) para eliminar caracteres no deseados
                    newArticulo.Precio = decimal.Parse(((decimal)data.LectorReader["Precio"]).ToString().TrimEnd('0', '.'));
                    categoria.Categorias = (string)data.LectorReader["Categoria"];




                    ListaArticulo.Add(newArticulo);
                }

                return ListaArticulo;

            }
			catch (Exception ex)
			{

				throw ex;
                
			}
            finally
            {
                data.cerrarConexion();
            }
        }


        //Traer registro de ventas
        public List<RegistroDeVentas> Registro()
        {
            List<RegistroDeVentas> RegistroVentas = new List<RegistroDeVentas> ();
            
            Data data = new Data();


            try
            {
                data.setearConsulta("select id,Codigo,producto,cantidad,FechaDeVenta,Precio from REGISTROS");
                data.ejecutarConsulta();

                while (data.LectorReader.Read())
                {
                    RegistroDeVentas newRegistro = new RegistroDeVentas();

                    
                    newRegistro.ID = (int)data.LectorReader["id"];
                    newRegistro.Codigo = (string)data.LectorReader["Codigo"];
                    newRegistro.Producto = (string)data.LectorReader["producto"];
                    newRegistro.Cantidad = (int)data.LectorReader["cantidad"];
                    DateTime Fecha = (DateTime)data.LectorReader["FechaDeVenta"];
                    newRegistro.Fecha = Fecha.ToString("dd-MM-yyyy");
                    newRegistro.Precio = (decimal)data.LectorReader["Precio"];

                    RegistroVentas.Add(newRegistro);

                }

                



                return RegistroVentas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }


        // Metodo Agregar registrosVentas
        public void Nuevoregistro(RegistroDeVentas registro)
        {

            Data data = new Data();

            try
            {
                data.setearConsulta("insert into REGISTROS (Codigo,Producto,Cantidad,FechaDeVenta,Precio) values('" + registro.Codigo + "','" + registro.Producto + "'," + registro.Cantidad + ", '" + registro.Fecha + "'," + registro.Precio + ")");
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }

        
        //metodo traer MARCAS

        public List<Marca> MarcaListar()
        {

            List<Marca> marca = new List<Marca>();
            Data data = new Data();

            try
            {
                
                data.setearConsulta("select Id,Descripcion FROM MARCAS");
                data.ejecutarConsulta();

                while (data.LectorReader.Read())
                {
                    Marca newMarca = new Marca();

                    newMarca.Marcas = (string)data.LectorReader["Descripcion"];
                    newMarca.Id = (int)data.LectorReader["Id"];

                    marca.Add(newMarca);
                }


                return marca;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }

        //metodo traer CATEGORIAS

        public List<Categoria> CategoriaLista()
        {
            Data data = new Data();
            List<Categoria> categoria = new List<Categoria>();
            try
            {
                data.setearConsulta("select Id,Descripcion FROM CATEGORIAS");
                data.ejecutarConsulta();

                while (data.LectorReader.Read())
                {
                    Categoria newCategoria = new Categoria();

                    newCategoria.Categorias = (string)data.LectorReader["Descripcion"];
                    newCategoria.Id = (int)data.LectorReader["Id"];

                    categoria.Add(newCategoria);
                }

                return categoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }


        // metodo agregar
        public void Agregar(Articulos newArticulos, Categoria idCategoria, Marca idMarca)
        {
            Data data = new Data();
            try
            {
                


                data.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,ImagenUrl,Precio,IdCategoria,IdMarca)values('" + newArticulos.Codigo + "','" + newArticulos.Nombre + "','" + newArticulos.Descripcion + "','" + newArticulos.Imagen + "', "+ newArticulos.Precio +  " ," + idCategoria.Id + "," + idMarca.Id + " )");
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }


        //Metodo eliminar art
        public void Eliminar(int id)
        {
            Data data = new Data();

            try
            {
                data.setearConsulta("delete ARTICULOS where id = " + id + "");
                data.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                data.cerrarConexion();
            }
        }

        //metodo eliminar registro
        public void EliminarRegistro(int id)
        {
            Data data = new Data();

            try
            {
                data.setearConsulta("delete REGISTROS where id = " + id + "");
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }


        //Metodo modificar art
        public void Modificar(Articulos articulo, Categoria categoria, Marca marca)
        {
            Data data = new Data();

            try
            {
                data.setearConsulta("update ARTICULOS set Codigo = '" + articulo.Codigo + "', Nombre = '" + articulo.Nombre + "', Descripcion = '" + articulo.Descripcion + "', IdMarca = " + marca.Id + ", IdCategoria = " + categoria.Id + ", ImagenUrl = '" + articulo.Imagen + "', Precio = " + articulo.Precio + " where Id = " + articulo.Id + " ");
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
}
