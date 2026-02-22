using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Crear 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // Crear 75 vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // Crear 75 vacunados con AstraZeneca
        HashSet<string> astra = new HashSet<string>();
        for (int i = 50; i <= 124; i++)
        {
            astra.Add("Ciudadano " + i);
        }

        // Ciudadanos con ambas dosis (intersección)
        var ambas = pfizer.Intersect(astra);

        // Ciudadanos solo Pfizer
        var soloPfizer = pfizer.Except(astra);

        // Ciudadanos solo AstraZeneca
        var soloAstra = astra.Except(pfizer);

        // Ciudadanos vacunados (unión)
        var vacunados = pfizer.Union(astra);

        // Ciudadanos no vacunados
        var noVacunados = ciudadanos.Except(vacunados);

        // Mostrar resultados
        Console.WriteLine("No vacunados: " + noVacunados.Count());
        Console.WriteLine("Ambas dosis: " + ambas.Count());
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count());
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count());
    }
}