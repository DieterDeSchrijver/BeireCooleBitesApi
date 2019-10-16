using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace BeireCooleBitesApi.Models
{
    public class Day
    {
        public ObjectId _id { get; set; }
        public int MaxCap { get; set; }

        public List<string> ListPersons { get; set; }

        public string DayName { get; set; }

        public Day(int maxCap, string dayName)
        {
            ListPersons = new List<string>();
            MaxCap = maxCap;
            DayName = dayName;
        }

        public bool IsDayFull()
        {
            return ListPersons.Count > MaxCap;
        }
        public void AddPerson(string name)
        {
            if (!IsDayFull())
            {
                ListPersons.Add(name);
            }
        }
    }
}