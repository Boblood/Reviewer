using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer.Models
{
    public class GameGameSystemLink
    {
        private int _id;
        private Game _gameid;
        private GameSystem _currentGameSystem;

        public int RefID { get; set; }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [ForeignKey("RefID")]
        public virtual Game GameID
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
