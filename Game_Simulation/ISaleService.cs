using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface ISaleService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
