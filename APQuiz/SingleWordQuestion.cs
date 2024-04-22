using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APQuiz
{
    internal class SingleWordQuestion : QuizQuestion
    {

        //vraag : welk keyword zorgt,,,
        //antwoord: abstract  // Abstract
        string antwoord;
        public SingleWordQuestion(string vraagtekst, string antwoordtekst)
        {
            VraagTekst = vraagtekst;
            antwoord = antwoordtekst.ToLower();
        }

        public override bool ControleerAntwoord(string gebruikerAntwoord)
        {
            return gebruikerAntwoord.ToLower() == antwoord;
        }
    }
}
