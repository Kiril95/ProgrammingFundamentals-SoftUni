using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Weather

{

    public class Forecast
    {
        public Forecast(double temperature, string weather)
        {
            Temperature = temperature;
            Weather = weather;          // Конструкторче
        }
        public double Temperature { get; set; }
        public string Weather { get; set; }

        class Program
        {
            static void Main(string[] args)
            {
                string command = Console.ReadLine();
                Dictionary<string, Forecast> result = new Dictionary<string, Forecast>();

                while (command != "end")
                {
                    Regex pattern = new Regex(@"(?<city>[A-Z]{2})(?<temp>[\d]+\.[\d]+)(?<forecast>[A-Za-z]+)\|");
                    Match matched = pattern.Match(command);

                    if (matched.Success)
                    {
                        string city = matched.Groups["city"].Value;
                        double temperature = double.Parse(matched.Groups["temp"].Value);
                        string weather = matched.Groups["forecast"].Value;
                        Forecast forecast = new Forecast(temperature, weather);
                        result[city] = forecast;

                    }
                    command = Console.ReadLine();
                }
                foreach (var item in result.OrderBy(x => x.Value.Temperature))
                {
                    Console.WriteLine($"{item.Key} => {item.Value.Temperature:f2} => {item.Value.Weather}");                 
                }
                
            }     
        }
    }
}
