using System;
using System.Collections.Generic;
using System.Linq;

namespace CountriesDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users/kellyredmond/Projects/cSharp/CountriesDemoApp/Pop_by_largest.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, List<Country>> countries = reader.ReadAllCountries();

            foreach (string region in countries.Keys)
                Console.WriteLine(region);

            Console.Write("Which of the above regions do you want? ");
            string chosenRegion = Console.ReadLine().Trim();

            if(countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                {
                    Console.WriteLine($"{PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
                }
            }
            else
            {
                Console.WriteLine("That is no a valid region");
            }

            //List<Country> countries = reader.ReadAllCountries();

            ////LINQ syntax - Take() not supported by query syntax
            //var filteredCountries = countries.Where(x => !x.Name.Contains(','));//.Take(20);
            //var filteredCountries2 = from country in countries
            //                         where !country.Name.Contains(',')
            //                         select country;

            //foreach(var country in filteredCountries2)
            //{
            //    Console.WriteLine($"{PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}

            //select certain items from list
            //foreach (var country in countries.Where(x => !x.Name.Contains(',')).Take(20))
            //{
            //    Console.WriteLine($"{PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}

            //order by name and return number of results
            //foreach (var country in countries.OrderBy(x=>x.Name).Take(10))
            //{
            //    Console.WriteLine($"{PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}

            ////remove countries
            //reader.RemoveCommaCountries(countries);

            //Console.Write("Enter number of countries to display: ");
            //bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            //if (!inputIsInt || userInput <= 0)
            //{
            //    Console.WriteLine("You must type in a positive integer. Exiting");
            //    return;
            //}

            //int maxToDisplay = Math.Min(userInput, countries.Count);
            //for (int i = 0; i < maxToDisplay; i++)
            //{
            //    Country country = countries[i];
            //    Console.WriteLine($"{PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}

            //int maxToDisplay = userInput;

            //for (int i = 0; i < countries.Count; i++)
            //{
            //    if (i > 0 && (i % maxToDisplay == 0))
            //    {
            //        Console.WriteLine("Hit return to continue, anything else to quit>");
            //        if (Console.ReadLine() != "")
            //            break;
            //    }
            //    Country country = countries[i];
            //    Console.WriteLine($"{i + 1}:  {PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}


            //high to low
            //for (int i = 0; i < countries.Count; i++)
            //{
            //    if (i > 0 && (i % maxToDisplay == 0))
            //    {
            //        Console.WriteLine("Hit return to continue, anything else to quit>");
            //        if (Console.ReadLine() != "")
            //            break;
            //    }
            //    Country country = countries[i];
            //    Console.WriteLine($"{i +1}:  {PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}

            //low to high
            //for (int i = countries.Count -1; i >= 0; i--)
            //{
            //    int displayIndex = countries.Count - 1 - i;
            //    if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
            //    {
            //        Console.WriteLine("Hit return to continue, anything else to quit>");
            //        if (Console.ReadLine() != "")
            //            break;
            //    }
            //    Country country = countries[i];
            //    Console.WriteLine($"{displayIndex + 1}:  {PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}


            // add and remove item to list
            //Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            //int lilliputIndex = countries.FindIndex(x => x.Population < 2_000_000);
            //countries.Insert(lilliputIndex, lilliput);
            //countries.RemoveAt(lilliputIndex);


            //foreach (var country in countries)
            //{
            //    Console.WriteLine($"{PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}

            //Console.WriteLine($"Number of countries {countries.Count}");

            //for (int i = 0; i < countries.Count; i++)
            //{
            //    Country country = countries[i];
            //    Console.WriteLine($"{PopulationFomatter.FormatPopulation(country.Population),-15}: {country.Name}");
            //}

            //Dictionary<string, Country> countries = reader.ReadAllCountries();

            //Console.WriteLine("Which country code do you want to look up? ");
            //string userInput = Console.ReadLine().ToUpper();

            //bool gotCountry = countries.TryGetValue(userInput, out Country country);

            //if (!gotCountry)
            //{
            //    Console.WriteLine($"Sorry, there is no country with the code, {userInput}");
            //}
            //else
            //{
            //    Console.WriteLine($"{country.Name} has population of {PopulationFomatter.FormatPopulation(country.Population)}");
            //}
        }
    }
}
