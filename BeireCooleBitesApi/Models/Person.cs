using System;
namespace BeireCooleBitesApi.Models
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
