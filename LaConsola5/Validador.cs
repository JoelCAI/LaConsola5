using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola5
{
    public class Validador
    {
        public static void TeclaControlG()
        {
            Console.Clear();
            ConsoleKeyInfo input;
            do
            {
                Console.WriteLine(" Presione Control + G al mismo tiempo si desea salir.");
                
                input = Console.ReadKey(true);

                Console.Clear();
                StringBuilder output = new StringBuilder(
                              String.Format("Usted Presionó {0}", input.Key.ToString()));
                bool modifiers = false;

                if ((input.Modifiers & ConsoleModifiers.Alt) == ConsoleModifiers.Alt)
                {
                    Console.Clear();
                    output.Append(" + " + ConsoleModifiers.Alt.ToString());
                    modifiers = true;
                }
                if ((input.Modifiers & ConsoleModifiers.Control) == ConsoleModifiers.Control)
                {
                    if (modifiers)
                    {
                        Console.Clear();
                        output.Append(" y ");
                    }
                    else
                    {
                        Console.Clear();
                        output.Append(" +");
                        modifiers = true;
                    }
                    output.Append(ConsoleModifiers.Control.ToString());
                }
                if ((input.Modifiers & ConsoleModifiers.Shift) == ConsoleModifiers.Shift)
                {
                    if (modifiers)
                    {
                        Console.Clear();
                        output.Append(" y ");
                    }
                    else
                    {
                        Console.Clear();
                        output.Append(" + ");
                        modifiers = true;
                    }
                    output.Append(ConsoleModifiers.Shift.ToString());
                }
                output.Append(".");
                Console.WriteLine(output.ToString());
                Console.WriteLine();
            } while (input.Key !=ConsoleKey.G || input.Modifiers != ConsoleModifiers.Control);

            if (input.Key == ConsoleKey.G || input.Modifiers == ConsoleModifiers.Control)
            {
                Validador.Despedida();
            }
        }

        public static void Despedida()
        {
            
            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }
    }
}
