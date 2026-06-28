using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsChatApp.Data
{
    internal class UserProfile
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FavouriteTopic { get; set; }
        public int HighestScore { get; set; }
    }
}
