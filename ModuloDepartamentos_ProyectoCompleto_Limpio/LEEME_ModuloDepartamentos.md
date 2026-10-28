# Módulo Departamentos — Avance 3

## Origen y alcance
Este proyecto se construyó **a partir de tu archivo `proyectodeInventarioII(1).zip`**.
Se conservan los formularios y recursos de la fase II y se incorporan solamente
las clases de Modelo y persistencia requeridas para Departamentos.

Los datos del módulo original son **Código, Nombre, Ubicación y Encargado**.
Esos cuatro campos se representaron en `Models/Departamento.cs`.

## Archivos nuevos
- `proyectodeInventarioII/Models/Departamento.cs`: entidad, constructor, propiedades, validación.
- `proyectodeInventarioII/Repositorios/IRepositorio.cs`: contrato CRUD genérico.
- `proyectodeInventarioII/Repositorios/RepositorioBase.cs`: persistencia reutilizable en JSON, lectura, escritura temporal, errores.
- `proyectodeInventarioII/Repositorios/RepositorioDepartamentos.cs`: heredado, validación de códigos únicos, búsqueda LINQ, CRUD.
- `Diagramas/DiagramaDepartamentos.png` y `.pdf`: UML del módulo.
- `PruebasDepartamentos/`: pruebas de persistencia independientes de formularios.

## Cómo abrir y probar
1. Abrir `proyectodeInventarioII.slnx` en Visual Studio 2026 / SDK .NET 10 con desarrollo de escritorio .NET.
2. Compilar la solución. Los formularios siguen siendo los mismos que los de la fase II.
3. Ejecutar las pruebas de datos: `dotnet run --project PruebasDepartamentos/PruebasDepartamentos.csproj`.
4. Las pruebas crean su propio archivo JSON temporal, sin tocar datos reales.

## Persistencia
`RepositorioDepartamentos()` utiliza `Datos/departamentos.json` bajo la carpeta donde
se ejecuta la aplicación. También admite pasar una ruta en el constructor.
Al leer, preserva archivos dañados y notifica errores; al guardar, escribe primero
un archivo temporal y luego lo reemplaza.

## Importante
El descriptor del avance 3 pide MODELOS y REPOSITORIOS; no exige conectar todavía
los formularios existentes. Por eso `frmDepartamentos` y `DepartamentoTemp` se
conservan como estaban: la interfaz NO usa aún el nuevo repositorio y sus
registros siguen siendo temporales hasta la fase de integración MVC.

**Verificación pendiente:** en este entorno no hay SDK .NET para compilar;
revisa la compilación y ejecuta las pruebas en Visual Studio antes de entregar.

El ZIP separado `ModuloDepartamentos_ParaGitHub.zip` está preparado para incorporar
el módulo al repositorio del equipo sin reemplazar sus formularios.
