namespace IdentityAss.Migrations
{
    using IdentityAss.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IdentityAss.DAL.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(IdentityAss.DAL.DataContext context)
        {
            var person = new List<Person>
            {
                new Person { FirstName = "Lionel " , LastName = "Messi" , Address = "Argentina"},
                new Person { FirstName = "Cristiano", LastName = "Ronaldo" , Address = "portugal" },
                new Person { FirstName = "Luis", LastName = "Suárez", Address = "Uruguay"},
                new Person { FirstName = "Andrés" , LastName = "Iniesta" ,Address = "Spain" },
                new Person { FirstName = "Gareth" , LastName = "Bale", Address = "Wiels"},
                new Person { FirstName = "Zlatan" , LastName = "Ibrahimović" ,Address = "Sweden" },
                new Person { FirstName = "Neymar" , LastName = " da Silva Santos Júnior" , Address = "Brazil" },
                new Person { FirstName = "Steven" , LastName = "Gerrard" , Address = "England"},
                new Person { FirstName = "Francesco" , LastName = "Totti" , Address = "Italy"}
            };
            person.ForEach(s => context.Persons.AddOrUpdate(p => p.FirstName,s));
            context.SaveChanges();

            var country = new List<Country>
            {
                new Country { Name = "US" },
                new Country { Name = "Sweden"},
                new Country { Name = "Canada" },
                new Country { Name = "Syria" }
            };
            country.ForEach(s => context.Countries.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var city = new List<City>
            {
               new City { Name = "Arizona" , CountryID = 1 },
               new City { Name = "New York" , CountryID = 1 },
               new City { Name = "Washington" , CountryID = 1 },
               new City { Name = "Stockholm" , CountryID = 2 },
               new City { Name = "Gothenburg" , CountryID = 2 },
               new City { Name = "Malmö" , CountryID = 2 },
               new City { Name = "British Columbia" , CountryID = 3 },
               new City { Name = "Alberta" , CountryID = 3 },
               new City { Name = "Malmö" , CountryID = 3 },
               new City { Name = "Damascus" , CountryID = 4 },
               new City { Name = "Aleppo" , CountryID = 4 },
               new City { Name = "Latakia" , CountryID = 4 },
            };
            city.ForEach(s => context.Cities.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

        }
    }
}
