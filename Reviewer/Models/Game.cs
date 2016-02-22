using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer.Models
{
    public class Game
    {
        #region Fields

        private int _id;
        private string _name;
        private string _publisher;
        private DateTime _releaseData;
        private GameSystem _gameConsole;        
        private string _desc;
        private string _reason;

        #endregion

        #region Properties

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public DateTime ReleaseDate
        {
            get { return _releaseData; }
            set { _releaseData = value; }
        }

        public GameSystem GameConsole
        {
            get { return _gameConsole; }
            set { _gameConsole = value; }
        }

        public string ReasonForGreatness
        {
            get { return _reason; }
            set { _reason = value; }
        }

        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }

        #endregion
    }
}
