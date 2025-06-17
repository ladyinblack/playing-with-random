using System;

class Program
{
    public static void Main(string[] args)
    {
        /** 
         * Generate a random int 
         */
        // Randomly generate a site number for displaying meter numbers
        Random random = new Random();
        int num = random.Next();

        /**
         * Generate a random number less than a number
         */
        // A random number below 100 
        int randomLessThan100 = random.Next(100);
        Console.WriteLine($"Random number less than 100: {randomLessThan100}");

        /**
         * Generate a random number within a range
         */
        // A random number within a range
        int randomBetween100And500 = random.Next(100, 500);
        Console.WriteLine($"\nRandom number between 100 and 500: {randomBetween100And500}");

        /**
         * Generate a random string
         */
        string randomString = RandomString(50, true);
        Console.WriteLine($"\nRandom string: {randomString}");

        // Generate a random number between any given range
        Console.WriteLine("\nGenerating a random number between a minimum and maximum");
        Console.Write("Enter a minimum number: ");
        int min1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a maximum number: ");
        int max1 = Convert.ToInt32(Console.ReadLine());
        int anyRandom1 = RandomNumber(min1, max1);
        Console.WriteLine($"Random number between {min1} and {max1} is: {anyRandom1}");

        // Generate a random number between a random min and max 
        Console.WriteLine("\nGenerating a random number between a random minimum and random maximum");
        int min2 = random.Next(0, 20);
        int max2 = random.Next(20, 50);
        int anyRandom2 = RandomNumber(min2, max2);
        Console.WriteLine($"Random number between {min2} and {max2} is: {anyRandom2}");

        /**
         * Generate a random password of a given length (optional) 
         */
        string password1 = RandomPassword();
        Console.WriteLine($"\nRandom password 1: {password1}");

        string password2 = RandomPassword(15);
        Console.WriteLine($"\nRandom password 2: {password2}");

        Console.ReadKey();
    }

    /**
     * HOW TO GENERATE A RANDOM STRING
     */
    // Generate a random string with a given size and case.
    // If second parameter is true, the return string is lowercase 
    public static string RandomString(int size, bool lowerCase)
    {
        StringBuilder builder = new StringBuilder();
        Random random = new Random();
        char ch;
        for (int i = 0; i < size; i++)
        {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }
        if (lowerCase)
            return builder.ToString().ToLower();

        return builder.ToString();
    }

    /**
     * GENERATING A RANDOM NUMBER BETWEEN MIN AND MAX 
     */
    public static int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    /**
     * CREATING A RANDOM PASSWORD COMBINATION OF STRINGS AND NUMBERS
     */
    public static string RandomPassword(int size = 0)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(RandomString(4, true));
        builder.Append(RandomNumber(1000, 9999));
        builder.Append(RandomString(2, false));

        return builder.ToString();
    }
}
