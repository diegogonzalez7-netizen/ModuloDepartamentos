using System;
using System.IO;
using System.Linq;
using proyectodeInventarioII.Models;
using proyectodeInventarioII.Repositorios;

string carpeta = Path.Combine(Path.GetTempPath(), "PruebaModuloDepartamentos_" + Guid.NewGuid().ToString("N"));
string archivo = Path.Combine(carpeta, "departamentos.json");
try
{
    var repo = new RepositorioDepartamentos(archivo);
    Asegurar(File.Exists(archivo), "No creo el JSON en primer uso.");
    Asegurar(repo.ObtenerTodos().Count == 0, "El JSON nuevo debe estar vacio.");

    repo.Agregar(new Departamento("D001", "Informatica", "Edificio A", "Ana Perez"));
    repo.Agregar(new Departamento("D002", "Recursos Humanos", "Edificio B", "Luis Lopez"));
    Asegurar(repo.ObtenerTodos().Count == 2, "Agregar: conteo incorrecto.");
    Asegurar(repo.BuscarPorCodigo("d001") is not null, "Busqueda insensible a mayusculas.");
    Asegurar(repo.BuscarTexto("luis").Count == 1, "Busqueda por encargado.");

    bool duplicado = false;
    try { repo.Agregar(new Departamento("d001", "Otro", "Piso 1", "Alguien")); }
    catch (InvalidOperationException) { duplicado = true; }
    Asegurar(duplicado, "Debe rechazar codigos repetidos.");

    var otraInstancia = new RepositorioDepartamentos(archivo);
    Asegurar(otraInstancia.ObtenerTodos().Count == 2, "Los datos no persisten.");
    otraInstancia.Actualizar(new Departamento("D001", "Sistemas", "Edificio C", "Maria"));
    Asegurar(new RepositorioDepartamentos(archivo).BuscarPorCodigo("D001")?.Nombre == "Sistemas", "Actualizar no persiste.");

    otraInstancia.Eliminar(new Departamento("D002", "Recursos Humanos", "Edificio B", "Luis Lopez"));
    Asegurar(new RepositorioDepartamentos(archivo).ObtenerTodos().Count == 1, "Eliminar no persiste.");

    File.WriteAllText(archivo, "{json dañado");
    bool detectoError = false;
    try { _ = new RepositorioDepartamentos(archivo); }
    catch (InvalidDataException) { detectoError = true; }
    Asegurar(detectoError, "Debe detectar JSON corrupto sin sobrescribirlo.");
    Asegurar(File.ReadAllText(archivo) == "{json dañado", "JSON corrupto fue modificado.");

    Console.WriteLine("TODAS LAS PRUEBAS DEL MODULO DEPARTAMENTOS PASARON.");
}
finally
{
    try { if (Directory.Exists(carpeta)) Directory.Delete(carpeta, true); } catch { }
}

static void Asegurar(bool condicion, string mensaje)
{
    if (!condicion) throw new Exception("PRUEBA FALLIDA: " + mensaje);
}
