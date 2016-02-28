using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer.Models
{
    public class Game
    {

        public Game()
        {
            GameConsoles = new List<GameSystem>();
        }

        #region Fields

        private int _id;
        private string _name;
        private string _publisher;
        private DateTime _releaseData;
        private ICollection<GameSystem> _gameConsoles;
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

        public int RefID { get; set; }

        [ForeignKey("RefID")]
        public virtual ICollection<GameSystem> GameConsoles
        {
            get { return _gameConsoles; }
            set { _gameConsoles = value; }
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
