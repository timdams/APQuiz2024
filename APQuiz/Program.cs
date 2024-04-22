namespace APQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> vragenLijst = new List<QuizQuestion>();

            vragenLijst.Add(new NumericQuestion());
            vragenLijst.Add(new SingleWordQuestion("Welke laptop heeft mr Dams", "Dell"));
            vragenLijst.Add(new SingleWordQuestion("Wie gaat haar naam veranderen volgend jaar?", "Els"));
            vragenLijst.Add(new NumericQuestion("Hoeveel volk zat er in de les vandaag?", 21));


            int score = 0;
            foreach (var item in vragenLijst)
            {
                Console.WriteLine("De vraag volgt nu....");
                Console.WriteLine(item);
                Console.WriteLine("Wat is het antwoord?");
                string antwoord = Console.ReadLine();
                if(item.ControleerAntwoord(antwoord))
                {
                    Console.WriteLine("HOERA. Puntje bij");
                    score++;
                }
                else
                    Console.WriteLine("MEUT!!!");


            }
            Console.WriteLine($"Je behaalde {100 * score/vragenLijst.Count}%");

        }
    }

   
}
