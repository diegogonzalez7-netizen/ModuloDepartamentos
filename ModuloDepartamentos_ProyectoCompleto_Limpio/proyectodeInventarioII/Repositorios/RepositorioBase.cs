using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace proyectodeInventarioII.Repositorios
{
    public class RepositorioBase<T> : IRepositorio<T> where T : class
    {
        protected BindingList<T> _entidades { get; } = new BindingList<T>();
        public string RutaArchivo { get; }

        private readonly JsonSerializerOptions _opciones = new()
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        protected RepositorioBase(string rutaArchivo)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(rutaArchivo);
            RutaArchivo = Path.GetFullPath(rutaArchivo);
        }

        public virtual void Agregar(T entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);
            if (_entidades.Contains(entidad))
                throw new InvalidOperationException("El registro ya existe.");

            var nuevos = _entidades.ToList();
            nuevos.Add(entidad);
            GuardarLista(nuevos);
            _entidades.Add(entidad);
        }

        public virtual void Actualizar(T entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);
            int indice = _entidades.IndexOf(entidad);
            if (indice < 0)
                throw new KeyNotFoundException("El registro no existe.");
            Guardar();
            _entidades.ResetItem(indice);
        }

        public virtual void Eliminar(T entidad)
        {
            ArgumentNullException.ThrowIfNull(entidad);
            if (!_entidades.Contains(entidad))
                throw new KeyNotFoundException("El registro no existe.");
            var nuevos = _entidades.ToList();
            nuevos.Remove(entidad);
            GuardarLista(nuevos);
            _entidades.Remove(entidad);
        }

        public BindingList<T> ObtenerTodos() => _entidades;

        public void Guardar() => GuardarLista(_entidades.ToList());

        public void Leer()
        {
            if (!File.Exists(RutaArchivo))
            {
                GuardarLista(new List<T>());
            }

            List<T> datos;
            try
            {
                string json = File.ReadAllText(RutaArchivo);
                datos = JsonSerializer.Deserialize<List<T>>(json, _opciones)
                    ?? throw new JsonException("Se esperaba una lista JSON.");
            }
            catch (JsonException ex)
            {
                throw new InvalidDataException(
                    $"JSON no valido en '{RutaArchivo}'. El archivo se conserva.", ex);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                throw new IOException($"No se puede leer '{RutaArchivo}'.", ex);
            }

            ValidarDatos(datos);
            _entidades.RaiseListChangedEvents = false;
            try
            {
                _entidades.Clear();
                foreach (var dato in datos) _entidades.Add(dato);
            }
            finally
            {
                _entidades.RaiseListChangedEvents = true;
                _entidades.ResetBindings();
            }
        }

        protected virtual void ValidarDatos(List<T> datos)
        {
            if (datos.Any(x => x is null))
                throw new InvalidDataException("La lista contiene elementos nulos.");
        }

        private void GuardarLista(List<T> datos)
        {
            ValidarDatos(datos);
            var json = JsonSerializer.Serialize(datos, _opciones);
            var dir = Path.GetDirectoryName(RutaArchivo)!;
            string temporal = RutaArchivo + "." + Guid.NewGuid().ToString("N") + ".tmp";
            try
            {
                Directory.CreateDirectory(dir);
                File.WriteAllText(temporal, json);
                File.Move(temporal, RutaArchivo, overwrite: true);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                throw new IOException($"No se pudo guardar '{RutaArchivo}'.", ex);
            }
            finally
            {
                if (File.Exists(temporal))
                {
                    try { File.Delete(temporal); } catch (IOException) { } catch (UnauthorizedAccessException) { }
                }
            }
        }
    }
}
