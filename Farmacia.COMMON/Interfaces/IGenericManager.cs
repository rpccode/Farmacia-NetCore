using Farmacia.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona  Metodos Estandarizados para el acceso a las tablas; 
    /// cada manager creado deve Implementar esta interfaz
    /// </summary>
    /// <typeparam name="T">tip de entidad de la cual se implementa el manager</typeparam>
    public interface IGenericManager<T> where T : BaseDTO
    {
        /// <summary>
        /// Proporciona Informacion sobre el error producido en una de las operaciones 
        /// </summary>
        public string Error { get; }

        /// <summary>
        /// Inserta una entidad en la tabla 
        /// </summary>
        /// <param name="entidad">Entidad a Insertar</param>
        /// <returns>Confirmacion de la Insercion</returns>
        bool Insertar(T entidad);

        /// <summary>
        /// Obtiene todos los registros de una tabla 
        /// </summary>
        IEnumerable<T> ObtenerTodos { get; }

        /// <summary>
        /// Modificamos  un registro en la tabla en base a la propiedad id
        /// </summary>
        /// <param name="entidad">Entidad Ya modificada, el id debe existir en la tabla para modificarse</param>
        /// <returns>Confirmacion de la actualizacion</returns>
        bool Actualizar(T entiidad);

        /// <summary>
        /// Elimina una Entidad en la base de dato de acuerdo al id proporcionado
        /// </summary>
        /// <param name="id">ID de la entidad a eliminar</param>
        /// <returns>confirmacion de la eliminacion </returns>
        bool Eliminar(string id);

        /// <summary>
        /// Va a Devolver una entidad de la base de datos en base a su id
        /// </summary>
        /// <param name="Id">Id de la entidad a obtener </param>
        /// <returns>Entidad que le corresponde el id proporcionado</returns>
        T BuscarPorId(string id);
    }
}
