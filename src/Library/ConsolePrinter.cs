using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
    public static void PrintRecipeConsole(Recipe recipe) 
        {     
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.getSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}

/*
    Para determinar como implementar este cambio se utiliza el principio SRP ya que lo que se
    busca es que cada clase tenga su propia responsabilidad, cosa que anteriormente no ocurría 
    debido a que la clase Recipe tenía la responsabilidad de agregar y quitar pasos además de 
    la de imprimir la receta en consola.

    Cambié el nombre del metodo de "PrintRecipe" a "PrintRecipeConsole" para notar que si en un 
    futuro continuaramos utilizando este mismo principio y nos pidieran por ejemplo imprimir la
    receta en una hoja de papel, crear otra clase que tenga esa responsabilidad especifica. 
*/