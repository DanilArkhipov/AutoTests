using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest3.Data
{
    public class MatchData
    {
        public string Title { get; set; }
        public string Sport { get; set; }

        public string Tournament { get; set; }

        public string Team1 { get; set; }

        public string Team2 { get; set; }

        public string Date { get; set; }
        public string Result { get; set; }

        public string Status { get; set; }

        public MatchData(string title, string sport, string tournament,
            string team1, string team2, string date, string result, string status)
        {
            Title = title;
            Sport = sport;
            Tournament = tournament;
            Team1 = team1;
            Team2 = team2;
            Date = date;
            Result = result;
            Status = status;
        }
    }
}
