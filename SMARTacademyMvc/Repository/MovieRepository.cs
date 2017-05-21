using System;

namespace SMARTacademyMvc.Controllers
{
    internal class MovieRepository
    {
        internal bool VerifyTitle(string title)
        {
            Random rand = new Random();
            double trueProbability = 0.5;
            return rand.NextDouble() < trueProbability;
        }
    }
}