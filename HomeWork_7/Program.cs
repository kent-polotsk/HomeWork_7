using ClassLibrary1;
using ClassLibrary2;
using ClassLibrary3;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        ConsoleKeyInfo key;
        do
        {
            //----------------------------------1--------------------------------------------
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Задание 1: инверсия массива");
                Console.ResetColor();
                List<ArrayWorker> arr = new List<ArrayWorker>();
                arr.Add(new ArrayWorker("Иван", "Иванов", 40));
                arr.Add(new ArrayWorker());
                arr.Add(new ArrayWorker("Перт", "Петров", 42));
                arr.Add(new ArrayWorker("Андрей", "Андреев", 21));
                arr.Add(new ArrayWorker("Дмитрий", "Дмитриев", 33));
                arr.Add(new ArrayWorker("Семен", "Семенов", 25));

                Console.WriteLine("Исходный массив: ");
                foreach (var worker in arr) { worker.Print(); }
                arr[0].ArrayReverse(ref arr);

                Console.WriteLine();
                Console.WriteLine("Инвертированный массив: ");
                foreach (var worker in arr) { worker.Print(); }
                Console.WriteLine();

                Console.WriteLine("Для продолжения нажмите любую кнопку, для выхода из программы нажмите Esc, для повтора нажмите y");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);

            } while (key.Key == ConsoleKey.Y);

            //----------------------------------2--------------------------------------------
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Задание 2: вычисление различных площадей конуса");
                Console.ResetColor();

                bool correctEnter = false;
                string? input;
                double height = 0, radius = 0;

                while (!correctEnter)
                {
                    Console.WriteLine("Введите высоту конуса: ");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out double result))
                    {
                        if (result > 0)
                        {
                            correctEnter = true;
                            height = result;
                        }
                        else Console.WriteLine("Некорректный ввод");
                    }
                    else Console.WriteLine("Некорректный ввод");
                }
                correctEnter = false;

                while (!correctEnter)
                {
                    Console.WriteLine("Введите радиус конуса: ");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out double result))
                    {
                        if (result > 0)
                        {
                            correctEnter = true;
                            radius = result;
                        }
                        else Console.WriteLine("Некорректный ввод");
                    }
                    else Console.WriteLine("Некорректный ввод");
                }
                correctEnter = false;

                Cone cone = new Cone();
                cone.BottomSquare(in radius);
                cone.SideSurfaceSquare(in radius, in height);
                cone.TotalSquare(in radius, in height);

                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую кнопку, для выхода из программы нажмите Esc, для повтора нажмите y");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);

            } while (key.Key == ConsoleKey.Y);

            //---------------------------------3-------------------------------------------
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Задание 3: Работа стека");
                Console.ResetColor();



                MyFirstStack myStack = new MyFirstStack();
                Console.WriteLine("(IsEmpty) Проверка стека пустой (true) или нет (false): " + myStack.IsEmpty());
                myStack.Push("111");
                myStack.Push("2");
                myStack.Push("_value_");
                myStack.Push("34");
                myStack.Push("House");
                myStack.Push("454");
                myStack.Push("5566");
                myStack.Push("6*/-");
                myStack.Push("6");
                myStack.Pop();
                myStack.Push("778");
                myStack.Push("RAND");
                Console.WriteLine("(IsEmpty) Проверка стека пустой (true) или нет (false): " + myStack.IsEmpty());
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                Console.WriteLine("(IsEmpty) Проверка стека пустой (true) или нет (false): " + myStack.IsEmpty());


                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую кнопку, для выхода из программы нажмите Esc, для повтора нажмите y");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);

            } while (key.Key == ConsoleKey.Y);

            //---------------------------------4-------------------------------------------

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Задание 4: Работа очереди");
                Console.ResetColor();


                MyFirstQueue myQueue = new MyFirstQueue();
                Console.WriteLine("(IsEmpty) Проверка очереди пустая (true) или нет (false): " + myQueue.IsEmpty());
                myQueue.Push("11");
                myQueue.Push("22");
                myQueue.Push("_value_");
                myQueue.Push("333");
                myQueue.Push("House");
                myQueue.Push("44");
                Console.WriteLine("(Size) Размер очереди: " + myQueue.Size());
                myQueue.Push("55");
                myQueue.Push("66");
                myQueue.Push("--");
                myQueue.Pop();
                myQueue.Push("78");
                myQueue.Push("99");
                Console.WriteLine("(IsEmpty) Проверка очереди пустая (true) или нет(false): " + myQueue.IsEmpty());
                Console.WriteLine("(Size) Размер очереди: " + myQueue.Size());
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                Console.WriteLine("(Size) Размер очереди: " + myQueue.Size());
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                myQueue.Pop();
                Console.WriteLine("(IsEmpty) Проверка очереди пустая (true) или нет(false): " + myQueue.IsEmpty());


                Console.WriteLine();
                Console.WriteLine("Для перезапуска программы нажмите любую кнопку, для выхода из программы нажмите Esc, для повтора задания нажмите y");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);

            } while (key.Key == ConsoleKey.Y);

        } while (key.Key != ConsoleKey.Escape);
    }
}