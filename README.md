# Workshop OOP — Manejo de horas

Proyecto de práctica de programación orientada a objetos en **C#/.NET 9**. Implementa una clase `Time` para representar una hora del día y una aplicación de consola que demuestra sus operaciones.

## Características

- Creación de horas con hora, minutos, segundos y milisegundos.
- Validación de rangos permitidos:
  - Hora: `0–23`
  - Minuto y segundo: `0–59`
  - Milisegundo: `0–999`
- Conversión de una hora a milisegundos, segundos y minutos.
- Suma de dos instancias de `Time`, incluyendo los acarreos entre unidades.
- Detección de si una suma pasa al día siguiente.
- Representación de la hora en formato de 12 horas (`AM`/`PM`).
- Manejo de excepciones ante valores inválidos.

## Estructura

```text
WorkshopOOP/
├── Backend/
│   ├── Backend.csproj       # Biblioteca de clases
│   └── Time.cs              # Entidad Time y su lógica
├── Frontend/
│   ├── Frontend.csproj      # Aplicación de consola
│   └── Program.cs           # Ejemplos de uso
├── WorkshopOOP.sln
└── README.md
```

## Requisitos

- [.NET SDK 9.0](https://dotnet.microsoft.com/download/dotnet/9.0) o una versión compatible.

## Ejecución

Desde la raíz del repositorio:

```bash
dotnet run --project Frontend/Frontend.csproj
```

También se puede abrir `WorkshopOOP.sln` en Visual Studio o Visual Studio Code y ejecutar el proyecto `Frontend`.

## Uso de `Time`

```csharp
using Backend;

var inicio = new Time(19, 45, 56);
var duracion = new Time(9, 34);

Console.WriteLine(inicio);                  // 07:45:56.000 PM
Console.WriteLine(inicio.ToMilliseconds());
Console.WriteLine(inicio.Add(duracion));    // 05:19:56.000 AM
Console.WriteLine(inicio.IsOtherDay(duracion)); // True
```

La aplicación de consola crea varias horas, imprime sus conversiones y prueba las operaciones de suma. Al final también intenta crear una hora inválida para mostrar el mensaje de validación correspondiente.

## Proyectos

| Proyecto | Tipo | Responsabilidad |
| --- | --- | --- |
| `Backend` | Biblioteca de clases | Contiene la clase `Time` y sus reglas de negocio. |
| `Frontend` | Aplicación de consola | Consume `Backend` y presenta ejemplos de uso. |

## Autoría

Taller académico de Programación Orientada a Objetos universidad ITM.
