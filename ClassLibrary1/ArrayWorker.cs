namespace ClassLibrary1
{
    public class ArrayWorker
    {

        private string FirstName = "Имя неизвестно";
        private string SecondName = "Фамилия неизвестна";
        private int Age = 0;

        public ArrayWorker() { }
        public ArrayWorker(string firstName, string secondName, int age) 
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }

        public void ArrayReverse(ref List<ArrayWorker> arrayWorkers) 
        {
            arrayWorkers.Reverse();
            //return arrayWorkers;
        }

        public void Print() 
        {
            Console.WriteLine(FirstName+" "+SecondName+" "+Age);
        }
    }           
}
