using System;
using System.ComponentModel;

namespace proyectodeInventarioII.Models
{
    public class Departamento : INotifyPropertyChanged
    {
        private string _codigo = string.Empty;
        private string _nombre = string.Empty;
        private string _ubicacion = string.Empty;
        private string _encargado = string.Empty;

        public string Codigo
        {
            get => _codigo;
            set => Establecer(ref _codigo, value ?? string.Empty, nameof(Codigo));
        }

        public string Nombre
        {
            get => _nombre;
            set => Establecer(ref _nombre, value ?? string.Empty, nameof(Nombre));
        }

        public string Ubicacion
        {
            get => _ubicacion;
            set => Establecer(ref _ubicacion, value ?? string.Empty, nameof(Ubicacion));
        }

        public string Encargado
        {
            get => _encargado;
            set => Establecer(ref _encargado, value ?? string.Empty, nameof(Encargado));
        }

        public Departamento() { }

        public Departamento(string codigo, string nombre, string ubicacion, string encargado)
        {
            Codigo = codigo;
            Nombre = nombre;
            Ubicacion = ubicacion;
            Encargado = encargado;
            Validar();
        }

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
                throw new ArgumentException("El codigo del departamento es obligatorio.");
            if (string.IsNullOrWhiteSpace(Nombre))
                throw new ArgumentException("El nombre del departamento es obligatorio.");
            if (string.IsNullOrWhiteSpace(Ubicacion))
                throw new ArgumentException("La ubicacion del departamento es obligatoria.");
            if (string.IsNullOrWhiteSpace(Encargado))
                throw new ArgumentException("El encargado del departamento es obligatorio.");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Establecer(ref string campo, string valor, string propiedad)
        {
            if (campo == valor) return;
            campo = valor;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
        }
    }
}
