// This file was auto-generated by ML.NET Model Builder. 

using System;
using Predict_a_numberML.Model;

namespace Predict_a_numberML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Sentence = @"Who is your hero?",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Type with predicted Type from sample data...\n\n");
            Console.WriteLine($"Sentence: {sampleData.Sentence}");
            Console.WriteLine($"\n\nPredicted Type value {predictionResult.Prediction} \nPredicted Type scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
