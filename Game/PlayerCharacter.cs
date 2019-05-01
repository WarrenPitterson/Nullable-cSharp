using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PlayerCharacter
    {
        public string Name { get; set; }

        public int? DaysSincelastLogin { get; set;}

        public DateTime? DateofBirth { get; set;}

        public bool? IsNew { get; set;}

        public PlayerCharacter()
        {
            DateofBirth = null;
            DaysSincelastLogin = null;        
        }

    }
}
