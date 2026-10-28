using System.ComponentModel;

namespace proyectodeInventarioII.Repositorios
{
    public interface IRepositorio<T>
    {
        void Agregar(T entidad);
        BindingList<T> ObtenerTodos();
        void Actualizar(T entidad);
        void Eliminar(T entidad);
    }
}
