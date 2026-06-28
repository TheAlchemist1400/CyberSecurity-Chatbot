using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsChatApp.Data
{
    internal class quizResults
    {
        public string UserName { get; set; }

        public int Score { get; set; }

        public int Total { get; set; }

        public double Percentage { get; set; }

        public DateTime DateTaken { get; set; }
    }
}
