using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        var answer = date;
        Console.WriteLine(answer);
        return answer;
    }

    public string Number03()
    {
        var now = _date.Now;
        var answer = $"Day {now:dd} of {now:MMMM, yyyy}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number04()
    {
        var now = _date.Now;
        var answer = $"Year: {now:yyyy}, Month: {now:MM}, Day: {now:dd}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number05()
    {
        var answer = $"{_date.Now,10:dddd}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number06()
    {
        var now = _date.Now;
        var answer = $"{now,10:t}{now,10:dddd}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number07()
    {
        var answer = $"{_date.Now:\\h:hh, \\m:MM, \\s:s}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number08()
    {
        var answer = $"{_date.Now:yyyy.MM.dd.hh.mm.s}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:C}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:F3}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number11()
    {
        var year = _date.Now.Year;
        var answer = $"0x{year:X}";
        Console.WriteLine(answer);
        return answer;
    }

}
