internal class Program
{
    private static string convertBase10ToBase2(string base10)
    {
        string answer = "";
        int number = int.Parse(base10);

        while(number > 0)
        {
            answer = number % 2 + answer;
            number /= 2;
        }

        return answer;
    }
    private static string binaryClock(string currentTime)
    {

        string[] currentTimeArray = currentTime.Split(':');
        string output = "";

        // convert hours in binary format
        string hourBinary = convertBase10ToBase2(currentTimeArray[0]);
        
        // convert minutes in binary format
        string minuteBinary = convertBase10ToBase2(currentTimeArray[1]);

        // convert seconds in binary format
        string secondBinary = convertBase10ToBase2(currentTimeArray[2]);

        output = hourBinary + ":" + minuteBinary + ":" + secondBinary;

        return output;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(binaryClock(DateTime.Now.ToString("HH:mm:ss")));
    }
}