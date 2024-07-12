using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;
using BibliotecaArqMod.EP_Usuario.Persistence.Models;

namespace BibliotecaArqMod.EP_Usuario.Persistence.Mappeo
{
    public class UsuarioMapper
    {
        /* ToEntity(CreateUsuarioModel modelUsuario)
       Convierte un modelo CreateUsuarioModel a una entidad Usuario*/
        public static Usuario ToEntity(Usuario entity)
        {
            return new Usuario
            {
                Id = entity.Id,
                NombreApellidos = entity.NombreApellidos,
                Correo = entity.Correo,
                Clave = entity.Clave,
                FechaCreacion = entity.FechaCreacion

            };
        }


        /* ToModel(Usuario entityUsuario)
       Convierte una entidad Usuario a un modelo CreateUsuarioModel*/
        public static Usuario ToModel(Usuario entityUsuario)
        {
            return new Usuario
            {
                Id = entityUsuario.Id,
                NombreApellidos = entityUsuario.NombreApellidos,
                Correo = entityUsuario.Correo,
                esActivo = entityUsuario.esActivo,
                FechaCreacion = entityUsuario.FechaCreacion

            };
        }

        /*UpdateEntityUsuario(UpdateUsuarioModel modelUsuario,Usuario entityUsuario) 
         Actualiza una entidad Usuario existente con los datos 
         proporcionados en un UpdateUsuarioModel*/
        public static void UpdateEntityUsuario(Usuario modelUsuario, Usuario entityUsuario)
        {

            entityUsuario.NombreApellidos = modelUsuario.NombreApellidos;
            entityUsuario.Correo = modelUsuario.Correo;
            entityUsuario.Clave = modelUsuario.Clave;
        }



        /* DeleteEntityUsuario(DeleteUsuarioModel deleteModel, Usuario deleteEntity)
         Elimina una entidad Usuario existente con los datos 
         proporcionados en un DeleteUsuarioModel */
        public static void DeleteEntityUsuario(Usuario deleteModel, Usuario deleteEntity)
        {

            deleteEntity.Id = deleteModel.Id;
            deleteEntity.NombreApellidos = deleteModel.NombreApellidos;
            deleteEntity.Correo = deleteModel.Correo;
            deleteEntity.Clave = deleteModel.Clave;
        }
    }
}
