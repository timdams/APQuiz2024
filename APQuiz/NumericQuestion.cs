using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APQuiz
{
    internal class NumericQuestion : QuizQuestion
    {
        int antwoord;
        public NumericQuestion(string vraag, int antwoordIn)
        {
            VraagTekst = vraag;
            antwoord = antwoordIn;
        }

        public NumericQuestion()
        {
            Random random = new Random();
            int g1 = random.Next(1, 10);
            int g2 = random.Next(1, 10);
            VraagTekst = $"Hoeveel is {g1}*{g2}?";
            antwoord = g1 * g2;
        }

        public override bool ControleerAntwoord(string gebruikerAntwoord)
        {
            return antwoord == int.Parse(gebruikerAntwoord);  //exception handling wanneer gebruiker iets anders dan een getal invoert
        }
    }
}
