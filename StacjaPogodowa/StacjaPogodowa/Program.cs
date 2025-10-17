

using DataBase;


    
        Weather weather = new Weather();
        Weather weather1 = new Weather();
        Console.WriteLine("Hello, World!");
        Console.ReadKey();
        weather1 = ChangerWeather(weather);
    
    Weather ChangerWeather(Weather weather)
    {
        var objectToChange = new Weather();
        Console.WriteLine($"Weather measured by: {weather.MeasuredBy}");
        weather.MeasuredBy = "Jan Kowalski";
        Console.WriteLine($"Weather measured by: {weather.MeasuredBy}");
        return objectToChange;
    }


