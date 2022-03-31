using  System;
namespace BG_Events

{
class Program
{
    static void Main(string[] args)
    {
            Work work = new Work();
            work.OnKeyProssed += Work_OnKeyPressed;
            Console.WriteLine("Для завершения программы нажмите C");
            Console.WriteLine("Введите символ");
            work.Run();
        }

        private static void Work_OnKeyPressed(Object sender, char x)
        { Console.WriteLine( $"{x}");
        }
}
    class Work
    {
        public event EventHandler <char>? OnKeyProssed;
        ConsoleKeyInfo w;
        public void Run()
        {
            while(Console.ReadKey().Key !=ConsoleKey.C)
            {  w = Console.ReadKey();
                char x = w.KeyChar;
                OnKeyProssed?.Invoke(this, x);
            }
        }
         

    }
}
