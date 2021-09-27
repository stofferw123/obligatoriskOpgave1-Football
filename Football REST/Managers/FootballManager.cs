using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using obligatoriskOpgave1_Football;

namespace Football_REST.Managers
{
    class FootballManager: IFootballManager
    {
        private static readonly List<FootballPlayer> players = new List<FootballPlayer>()
        {
            new FootballPlayer(1, "brian", 12000, 24),
            new FootballPlayer(2, "Peter", 25000.240, 76),
            new FootballPlayer(3, "Uffe", 6789, 85)
        };
        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(players);
        }

        public FootballPlayer Get(int id)
        {
            return players.Find(p => p.ID == id);
        }

        public bool Create(FootballPlayer value)
        {
            players.Add(value);
            return true;
        }

        public bool Update(int id, FootballPlayer value)
        {
            FootballPlayer item = Get(id);
            if (item != null)
            {
                item.ID = value.ID;
                item.Name = value.Name;
                item.Price = value.Price;
                item.ShirtNumber = value.ShirtNumber;
                return true;
            }
            return false;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = Get(id);
            players.Remove(player);
            return player;
        }
    }
}
