using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int Screenings { get; set; }
        public double PricePerTicket { get; set; }
        public double TotalRevenue { get; set; }
        public double Cost { get; set; }
        public double Budget { get; set; }

        public double RevenuePerScreening()
        {
            return TotalRevenue / Screenings;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Func<int, int> MultiplyBy2 = score => score * 2;
            // int MultiplyBy2(int value)
            // {
            //     return value * 2;
            // }
            var scores = new List<int> { 42, 100, 98, 15 };
            // var newScores = new List<int>();
            // foreach (var score in scores)
            // {
            //     var doubled = MultiplyBy2(score);
            //     newScores.Add(doubled);
            // }
            var newScores = scores.Select(score => score * 2);   //this shortens the code using Select method from LINQ // (replaces Func<>)
            var slightlyBetterScore = scores.Select(score => score + 1);

            // Console.WriteLine();

            var listOfFilms = new List<Movie>()
            {
              new Movie()
              {
                  Id = 1,
                  Name = "Dorm Daze (National Lampoon Presents Dorm Daze)",
                  Tagline = "Multi-tiered modular standardization",
                  ReleasedDate = DateTime.Parse("3/27/2019"),
                  Screenings = 186,
                  PricePerTicket = 11,
                  TotalRevenue = 13361359,
                  Cost = 18274829,
                  Budget = 8210089
              },

              new Movie()
              {
                  Id = 2,
                  Name = "Born Yesterday",
                  Tagline = "Managed empowering open system",
                  ReleasedDate = DateTime.Parse("2/12/2014"),
                  Screenings = 184,
                  PricePerTicket = 11,
                  TotalRevenue = 6563796,
                  Cost = 9021912,
                  Budget = 11364786
              },

              new Movie()
              {
                  Id = 3,
                  Name = "Darjeeling Limited, The",
                  Tagline = "Quality-focused actuating initiative",
                  ReleasedDate = DateTime.Parse("8/21/2013"),
                  Screenings = 177,
                  PricePerTicket = 10,
                  TotalRevenue = 17851792,
                  Cost = 5441889,
                  Budget = 12144397
              },

              new Movie()
              {
                  Id = 4,
                  Name = "Offside",
                  Tagline = "Enhanced homogeneous migration",
                  ReleasedDate = DateTime.Parse("4/18/2019"),
                  Screenings = 169,
                  PricePerTicket = 11,
                  TotalRevenue = 1445952,
                  Cost = 4008467,
                  Budget = 7417825
              },

              new Movie()
              {
                  Id = 5,
                  Name = "Superman vs. The Elite",
                  Tagline = "Stand-alone systematic model",
                  ReleasedDate = DateTime.Parse("12/7/2016"),
                  Screenings = 124,
                  PricePerTicket = 19,
                  TotalRevenue = 13737676,
                  Cost = 18893333,
                  Budget = 6585110
              },

              new Movie()
              {
                  Id = 6,
                  Name = "Body Snatchers",
                  Tagline = "Diverse holistic data-warehouse",
                  ReleasedDate = DateTime.Parse("1/12/2007"),
                  Screenings = 170,
                  PricePerTicket = 10,
                  TotalRevenue = 10540575,
                  Cost = 12946787,
                  Budget = 9237906
              },

              new Movie()
              {
                  Id = 7,
                  Name = "Death and Cremation",
                  Tagline = "Ergonomic local knowledge base",
                  ReleasedDate = DateTime.Parse("4/1/2013"),
                  Screenings = 138,
                  PricePerTicket = 10,
                  TotalRevenue = 12361644,
                  Cost = 7326663,
                  Budget = 16829534
              },

              new Movie()
              {
                  Id = 8,
                  Name = "Other End of the Line, The",
                  Tagline = "Up-sized demand-driven policy",
                  ReleasedDate = DateTime.Parse("11/15/2016"),
                  Screenings = 169,
                  PricePerTicket = 12,
                  TotalRevenue = 6371172,
                  Cost = 17279838,
                  Budget = 14274676
              },

              new Movie()
              {
                  Id = 9,
                  Name = "Our Mother's House",
                  Tagline = "Enhanced methodical algorithm",
                  ReleasedDate = DateTime.Parse("7/20/2018"),
                  Screenings = 188,
                  PricePerTicket = 17,
                  TotalRevenue = 3544170,
                  Cost = 7953388,
                  Budget = 19636220
              },

              new Movie()
              {
                  Id = 10,
                  Name = "Everything I Can See From Here",
                  Tagline = "Synchronized 24/7 utilization",
                  ReleasedDate = DateTime.Parse("7/26/2012"),
                  Screenings = 84,
                  PricePerTicket = 4,
                  TotalRevenue = 14520267,
                  Cost = 2766779,
                  Budget = 2478292
              },

              new Movie()
              {
                  Id = 11,
                  Name = "My Rainy Days",
                  Tagline = "Cloned static array",
                  ReleasedDate = DateTime.Parse("8/4/2015"),
                  Screenings = 104,
                  PricePerTicket = 15,
                  TotalRevenue = 6860536,
                  Cost = 6622076,
                  Budget = 1091525
              },

              new Movie()
              {
                  Id = 12,
                  Name = "Five Graves to Cairo",
                  Tagline = "Ergonomic heuristic capacity",
                  ReleasedDate = DateTime.Parse("10/25/2013"),
                  Screenings = 65,
                  PricePerTicket = 17,
                  TotalRevenue = 13595001,
                  Cost = 3736299,
                  Budget = 724740
              },

              new Movie()
              {
                  Id = 13,
                  Name = "Hunted, The",
                  Tagline = "Multi-channelled object-oriented groupware",
                  ReleasedDate = DateTime.Parse("2/4/2014"),
                  Screenings = 185,
                  PricePerTicket = 7,
                  TotalRevenue = 13273082,
                  Cost = 14879296,
                  Budget = 7461416
              },

              new Movie()
              {
                  Id = 14,
                  Name = "Charlie Chan's Courage",
                  Tagline = "Implemented interactive installation",
                  ReleasedDate = DateTime.Parse("5/25/2006"),
                  Screenings = 50,
                  PricePerTicket = 10,
                  TotalRevenue = 15695655,
                  Cost = 11372062,
                  Budget = 9089553
              },

              new Movie()
              {
                  Id = 15,
                  Name = "When Will I Be Loved",
                  Tagline = "Networked uniform toolset",
                  ReleasedDate = DateTime.Parse("8/25/2015"),
                  Screenings = 165,
                  PricePerTicket = 21,
                  TotalRevenue = 10095292,
                  Cost = 16020659,
                  Budget = 15707348
              },

              new Movie()
              {
                  Id = 16,
                  Name = "Viva Las Vegas",
                  Tagline = "Digitized dedicated capability",
                  ReleasedDate = DateTime.Parse("7/4/2015"),
                  Screenings = 85,
                  PricePerTicket = 16,
                  TotalRevenue = 16406383,
                  Cost = 9854228,
                  Budget = 16042287
              },

              new Movie()
              {
                  Id = 17,
                  Name = "Topaze",
                  Tagline = "Advanced high-level benchmark",
                  ReleasedDate = DateTime.Parse("12/1/2010"),
                  Screenings = 60,
                  PricePerTicket = 4,
                  TotalRevenue = 13809680,
                  Cost = 12667720,
                  Budget = 14805773
              },

              new Movie()
              {
                  Id = 18,
                  Name = "The Clinic",
                  Tagline = "Polarized regional solution",
                  ReleasedDate = DateTime.Parse("4/20/2013"),
                  Screenings = 128,
                  PricePerTicket = 8,
                  TotalRevenue = 17416537,
                  Cost = 3435812,
                  Budget = 8818065
              },

              new Movie()
              {
                  Id = 19,
                  Name = "The Land Before Time X: The Great Longneck Migration",
                  Tagline = "Adaptive dedicated workforce",
                  ReleasedDate = DateTime.Parse("10/10/2008"),
                  Screenings = 170,
                  PricePerTicket = 21,
                  TotalRevenue = 5720197,
                  Cost = 10514309,
                  Budget = 3781872
              },

              new Movie()
              {
                  Id = 20,
                  Name = "Tarzan",
                  Tagline = "Polarized intangible productivity",
                  ReleasedDate = DateTime.Parse("12/31/2006"),
                  Screenings = 105,
                  PricePerTicket = 19,
                  TotalRevenue = 6338974,
                  Cost = 18402771,
                  Budget = 844331
              },

              new Movie()
              {
                  Id = 21,
                  Name = "Jaws",
                  Tagline = "When a killer shark unleashes chaos on a beach community, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down. ",
                  ReleasedDate = DateTime.Parse("1/1/1975"),
                  Screenings = 105,
                  PricePerTicket = 7,
                  TotalRevenue = 6338974,
                  Cost = 18402771,
                  Budget = 844331
              }
            };

            var movieNames = listOfFilms.Select(film => film.Name);
            var movieNamesWithIndex = listOfFilms.Select((film, index) => $"The movie named {film.Name} is at position {index}");
            // var tacoTuesday = listOfFilms.Select((film, index) => index * 100);

            IEnumerable<double> averages = listOfFilms.Select(movie => movie.RevenuePerScreening());

            var popularFilms = listOfFilms.Where(film => film.Screenings >= 100);      //.Select(film => film.Name);



            foreach (var minute in movieNames)
            {
                Console.WriteLine(minute);
            }

            double totalRevenue = popularFilms.Aggregate(0.0, (fuck1, fuck2) => fuck1 + fuck2.TotalRevenue);

            Console.WriteLine(totalRevenue);

            IEnumerable<double> allRevenues = listOfFilms.Select(fuck3 => fuck3.TotalRevenue);
            double totalRevenue3 = allRevenues.Sum();
            Console.WriteLine($"Total revenue for all {movieNames.Count()} movies is {totalRevenue3}. ");
            Console.WriteLine($"Total for the {popularFilms.Count()} movies that were screened more than 100 times is {totalRevenue}. ");

            double totalRev4 = listOfFilms.Sum(fuck4 => fuck4.TotalRevenue); //coding the above in one line.
            Console.WriteLine($"Another way to code the total revenues of all {movieNames.Count()} movies. Which is {totalRev4}. ");

            bool oldMovies = listOfFilms.All(fuck => fuck.ReleasedDate.Year > 1965);
            bool anyOldMovies = popularFilms.Any(fuk => fuk.ReleasedDate.Year > 1965);

            Console.WriteLine(oldMovies);
            Console.WriteLine(anyOldMovies);

            int movies1 = listOfFilms.Count(fak => fak.PricePerTicket > 10);
            int movies2 = listOfFilms.Where(fak => fak.PricePerTicket > 10).Count();

            Console.WriteLine($"Two ways to code the same info of how many movies cost more than 10 bucks. {movies1} {movies2}. ");

            var favoriteMovie = listOfFilms.FirstOrDefault(fak => fak.Name == "Jaws");

            if (favoriteMovie == null)
            {
                Console.WriteLine("Nope! Hot Here!");
            }
            else
            {
                Console.WriteLine(favoriteMovie.Name);
            };



        }
    }
}
