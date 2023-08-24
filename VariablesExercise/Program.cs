namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Henny";
            int dogAge = 6;
            char firstLetter = 'H';
            bool isDog = true;
            double dogPrice = 100;
            decimal dogValue = 1000.00m;
            
            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old. " +
                $"The first letter of his name starts with an {firstLetter}. It is {isDog} that he is a dog. " +
                $"I paid ${dogPrice} for him, but the value he brings to my family exceeds ${dogValue}." );
        }
    }
}
