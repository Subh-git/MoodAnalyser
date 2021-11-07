using System;

namespace MoodAnalyser01_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser mood = new MoodAnalyser("I am happy");
            Console.WriteLine(mood.AnalyseMood());
        }
    }
}
