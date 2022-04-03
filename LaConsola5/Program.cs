using System;
using System.Text;

public class ConsoleKeyExample
{
    public static void Main()
    {
        ConsoleKeyInfo input;
        do
        {
            Console.WriteLine(" Presione Control + F al mismo tiempo.");
            Console.WriteLine("Press Esc to exit.");
            input = Console.ReadKey(true);

            StringBuilder output = new StringBuilder(
                          String.Format("Presionó {0}", input.Key.ToString()));
            bool modifiers = false;

            if ((input.Modifiers & ConsoleModifiers.Alt) == ConsoleModifiers.Alt)
            {
                output.Append(" + " + ConsoleModifiers.Alt.ToString());
                modifiers = true;
            }
            if ((input.Modifiers & ConsoleModifiers.Control) == ConsoleModifiers.Control)
            {
                if (modifiers)
                {
                    output.Append(" y ");
                }
                else
                {
                    output.Append(" +");
                    modifiers = true;
                }
                output.Append(ConsoleModifiers.Control.ToString());
            }
            if ((input.Modifiers & ConsoleModifiers.Shift) == ConsoleModifiers.Shift)
            {
                if (modifiers)
                {
                    output.Append(" y ");
                }
                else
                {
                    output.Append(" + ");
                    modifiers = true;
                }
                output.Append(ConsoleModifiers.Shift.ToString());
            }
            output.Append(".");
            Console.WriteLine(output.ToString());
            Console.WriteLine();
        } while (input.Key != ConsoleKey.Escape);
    }
}
