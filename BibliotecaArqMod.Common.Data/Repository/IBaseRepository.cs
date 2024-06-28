
using System.Linq.Expressions;

namespace BibliotecaArqMod.Common.Data.Repository
{
    /// <summary>
    /// 
    /// 
    /// En este caso la interfaz IBaseRepository es la que contiene los metodos del CRUD
    /// en nuestro proyecto pero la peculiaridad de nuestra interfaz es que es tipo generica
    /// esto con el propocido de que la interfaz pueda ser reutilizada en cada uno de los modulos 
    /// de nuestro proyecto si es necesario y asi tambien evitamos tener que crear cada uno de los
    /// metodos por Modulo
    /// 
    /// 
    /// </summary>
    /// 
    /// <typeparam name="TEntity"> TEntity va a recibir la entidad o modulo </typeparam>
    /// 
    /// <typeparam name="TType"> TType va a recibir el tipo de dato que sea la entidad o modulo </typeparam>
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        List<TEntity> GetAll();
        TEntity GetEntityById(TType Id);


        //El método Exists es comúnmente utilizado en los repositorios para verificar
        //si alguna entidad del tipo TEntity cumple con una condición especificada por una expresión lambda.

        bool Exists(Expression<Func<TEntity, bool>> expression); 
    }
}
