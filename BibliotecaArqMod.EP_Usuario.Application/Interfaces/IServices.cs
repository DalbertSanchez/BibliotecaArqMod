
using BibliotecaArqMod.EP_Usuario.Application.Core;

namespace BibliotecaArqMod.EP_Usuario.Application.Interfaces
{
    public interface IServices<TCreateDto, TUpdateDto, TDeleteDto,TEntity>
        where TCreateDto : class 
        where TUpdateDto : class 
        where TEntity : class 
        where TDeleteDto : class
    {
        ServiceResult GetEntity();
        ServiceResult GetEntityByID(int id);
        ServiceResult Update(TUpdateDto updateDto);
        ServiceResult Delete(TDeleteDto deleteDto);
        ServiceResult Create(TCreateDto createDto);
    }
}
