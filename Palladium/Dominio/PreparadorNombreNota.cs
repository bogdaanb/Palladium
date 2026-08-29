using System;

namespace Palladium.Dominio;

public static class PreparadorNombreNota
{
    public static string Preparar(string? nombreNota)
    {
        if (string.IsNullOrWhiteSpace(nombreNota))
        {
            throw new ArgumentException(
                "El nombre no puede estar vacío.");
        }

        string nombreLimpio = nombreNota.Trim();

        if (nombreLimpio.EndsWith(
                ".md",
                StringComparison.OrdinalIgnoreCase))
        {
            return nombreLimpio;
        }

        return nombreLimpio + ".md";
    }
}