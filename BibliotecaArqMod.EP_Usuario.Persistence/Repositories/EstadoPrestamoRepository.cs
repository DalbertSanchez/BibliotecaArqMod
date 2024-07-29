using System.Linq.Expressions;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;
using BibliotecaArqMod.EP_Usuario.Domain.Interfaces;
using BibliotecaArqMod.EP_Usuario.Persistence.Context;
using BibliotecaArqMod.EP_Usuario.Persistence.Mappeo;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaArqMod.EP_Usuario.Persistence.Repositories
{
    /// <summary>
    /// Objetos de los DbObjects
    /// </summary>
    public class EstadoPrestamoRepository : IEstadoPrestamoRepository
    {

        private readonly BibliotecaContext context;

        public EstadoPrestamoRepository(BibliotecaContext context)
        {
            this.context = context;
        }

        public void Create(EstadoPrestamo entity)
        {
            var estadoPrestamo = EstadoPrestamoMapper.ToEntity(entity);
            estadoPrestamo.Estado = true;

            this.context.EstadoPrestamo.Add(estadoPrestamo);
            this.context.SaveChanges();
        }

        public void Delete(EstadoPrestamo entity)
        {
            EstadoPrestamo estadoPrestamoToDelete = this.context.EstadoPrestamo.Find(entity.Id);

            if (estadoPrestamoToDelete == null)
            {
                throw new ArgumentException("Estado Prestamo no encontrado");
            }

            // Utilizar el método DeleteEntityEstadoPrestamo para eliminar la entidad con los datos de eliminación
            EstadoPrestamoMapper.DeleteEntityEstadoPrestamo(entity, estadoPrestamoToDelete);

            estadoPrestamoToDelete.Estado = false;
            // Actualizar la entidad en el contexto y guardar los cambios en la base de datos
            this.context.EstadoPrestamo.Remove(estadoPrestamoToDelete);
            this.context.SaveChanges();
        }

        public bool Exists(Expression<Func<EstadoPrestamo, bool>> expression)
        {
            return context.Set<EstadoPrestamo>().Any(expression);
        }

        public List<EstadoPrestamo> GetAll()
        {
            return this.context.EstadoPrestamo.Select(EstadoPrestamoMapper.ToModel).ToList();
        }

        public EstadoPrestamo GetEntityById(int Id)
        {
            var estadoPrestamo = this.context.EstadoPrestamo.Find(Id);

            return EstadoPrestamoMapper.ToModel(estadoPrestamo);
        }

        public void Update(EstadoPrestamo entity)
        {
            EstadoPrestamo estadoPrestamoToUpdate = this.context.EstadoPrestamo.Find(entity.Id);
            EstadoPrestamoMapper.UpdateEntityEstadoPrestamo(entity, estadoPrestamoToUpdate);


            this.context.EstadoPrestamo.Update(estadoPrestamoToUpdate);
            this.context.SaveChanges();
        }
    }
}
