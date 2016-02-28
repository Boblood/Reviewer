using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer.Models
{
    public class GameGameSystemLink
    {
        private int _id;
        private int _gameid;
        private GameSystem _currentGameSystem;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int GameID
        {
            get { return _gameid; }
            set { _gameid = value; }
        }
        public GameSystem CurrentGameSystem
        {
            get { return _currentGameSystem; }
            set { _currentGameSystem = value; }
        }
    }
}
