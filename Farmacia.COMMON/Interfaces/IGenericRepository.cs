using Farmacia.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona los metodos basico(CRUD) de acceso a una base de datos 
    /// </summary>
    /// <typeparam name="T">el tipo de entidad a la que se refiere una tabla</typeparam>
    public interface IGenericRepository<T> where T : BaseDTO
    {
        /// <summary>
        /// Proporciona Informacion sobre el error producido en una de las operaciones 
        /// </summary>
        string Error { get; }
        /*
         * CRUD=>Create (Insert), Read (Select), Update (update), delete (delete)
         */

        /// <summary>
        /// Inserta una entidad en la tabla 
        /// </summary>
        /// <param name="entidad">Entidad a Insertar</param>
        /// <returns>Confirmacion de la Insercion</returns>
        bool Create(T entidad);

        /// <summary>
        /// Obtiene todos los registros de una tabla 
        /// </summary>
        IEnumerable<T> Read { get; }

        /// <summary>
        /// Modificamos  un registro en la tabla en base a la propiedad id
        /// </summary>
        /// <param name="entidad">Entidad Ya modificada, el id debe existir en la tabla para modificarse</param>
        /// <returns>Confirmacion de la actualizacion</returns>
        bool Update(T entidad);


        /// <summary>
        /// Elimina una Entidad en la base de dato de acuerdo al id proporcionado
        /// </summary>
        /// <param name="id">ID de la entidad a eliminar</param>
        /// <returns>confirmacion de la eliminacion </returns>
        bool Delete(string id);

        //Query->Realizar consultas a las tablas, Mediante expreciones lamba

        /// <summary>
        /// Realiza una consulta personalizada a la tabla 
        /// </summary>
        /// <param name="predicado">Expreciones lambda que define la consulta</param>
        /// <returns>Conjunto de entidades que cumplen la consulta</returns>
        IEnumerable<T> Query(Expression<Func<T, bool>> predicado);


        /// <summary>
        /// Va a Devolver una entidad de la base de datos en base a su id
        /// </summary>
        /// <param name="Id">Id de la entidad a obtener </param>
        /// <returns>Entidad que le corresponde el id proporcionado</returns>
        T SearchById(string Id);

    }
}
