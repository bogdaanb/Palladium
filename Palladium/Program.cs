using Palladium.Dominio.Archivos;

Console.Write("Introduce el nombre de la nota: ");
string? nombreNota = Console.ReadLine();

string nombreArchivo =
    PreparadorNombreNota.Preparar(nombreNota);

string carpetaNotas = "Notas";

Directory.CreateDirectory(carpetaNotas);

string rutaCompleta =
    Path.Combine(carpetaNotas, nombreArchivo);

File.WriteAllText(rutaCompleta, "");

Console.WriteLine("Nota creada correctamente.");
Console.WriteLine("Ruta: " + rutaCompleta);