﻿using System;
using System.Collections.Generic;
using CA3.Shared;

namespace CA3.Shared
{
    public class AllClasses
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Filters
        {
            public string matchday { get; set; }
        }

        public class Area
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Competition
        {
            public int id { get; set; }
            public Area area { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public string plan { get; set; }
            public DateTime lastUpdated { get; set; }
        }

        public class Season
        {
            public int id { get; set; }
            public string startDate { get; set; }
            public string endDate { get; set; }
            public int currentMatchday { get; set; }
        }

        public class Odds
        {
            public string msg { get; set; }
        }

        public class FullTime
        {
            public int homeTeam { get; set; }
            public int awayTeam { get; set; }
        }

        public class HalfTime
        {
            public int homeTeam { get; set; }
            public int awayTeam { get; set; }
        }

        public class ExtraTime
        {
            public object homeTeam { get; set; }
            public object awayTeam { get; set; }
        }

        public class Penalties
        {
            public object homeTeam { get; set; }
            public object awayTeam { get; set; }
        }

        public class Score
        {
            public string winner { get; set; }
            public string duration { get; set; }
            public FullTime fullTime { get; set; }
            public HalfTime halfTime { get; set; }
            public ExtraTime extraTime { get; set; }
            public Penalties penalties { get; set; }
        }

        public class HomeTeam
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class AwayTeam
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Referee
        {
            public int id { get; set; }
            public string name { get; set; }
            public string role { get; set; }
            public string nationality { get; set; }
        }

        public class Match
        {
            public int id { get; set; }
            public Season season { get; set; }
            public DateTime utcDate { get; set; }
            public string status { get; set; }
            public int matchday { get; set; }
            public string stage { get; set; }
            public object group { get; set; }
            public DateTime lastUpdated { get; set; }
            public Odds odds { get; set; }
            public Score score { get; set; }
            public HomeTeam homeTeam { get; set; }
            public AwayTeam awayTeam { get; set; }
            public List<Referee> referees { get; set; }
            public List<Match> match { get; set; }
        }

        public class Root
        {
            public int count { get; set; }
            public Filters filters { get; set; }
            public Competition competition { get; set; }
            public List<Match> matches { get; set; }
           
        }

      


        



    }
}
