using Predict_a_numberML.Model;
using System;
namespace predict_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to GrammerAI by Chase. Type a sentence, and I will determine if it is a question or a statement.");
            while (true)
            {
                string sentence = Console.ReadLine();
                Console.WriteLine("Hold on, we are finding the sentence type.");
                // Add input data
                var input = new ModelInput();
                input.Sentence = sentence;
                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine("GrammarAI has determined this is a " + result.Prediction.ToString());
            }
        }
    }
}
