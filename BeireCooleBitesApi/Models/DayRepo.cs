using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BeireCooleBitesApi.Models
{
    public class DayRepo
    {
        private MongoClient client;
        private IMongoDatabase _database;
        private IMongoCollection<Day> _days;
        
        public DayRepo()
        {
            client =  new MongoClient(
                "mongodb+srv://admin:admin@beirecool-bwo5b.gcp.mongodb.net/test?retryWrites=true&w=majority");
            _database = client.GetDatabase("BeireCooleBites");

            _days = _database.GetCollection<Day>("Days");

        }

        public List<Day> getAll()
        {
            return _days.Find(day => true).ToList();
        }
        
        public void create()
        {
            Day maandag = new Day(40, "maandag");
            _days.InsertOne(maandag);
            
            Day dinsdag = new Day(40, "dinsdag");
            _days.InsertOne(dinsdag);
            
            Day woensdag = new Day(40, "woensdag");
            _days.InsertOne(woensdag);
            
            Day donderdag = new Day(40, "donderdag");
            _days.InsertOne(donderdag);
            
            Day vrijdag = new Day(40, "vrijdag");
            _days.InsertOne(vrijdag);
        }

        public void AddPerson(string naam, string dag)
        {

            var day = _days.Find(day => day.DayName.Equals(dag)).FirstOrDefault();
            day.AddPerson(naam);

            _days.ReplaceOne(d => d.DayName == dag
                ,
                day
            );
        }
    }
}