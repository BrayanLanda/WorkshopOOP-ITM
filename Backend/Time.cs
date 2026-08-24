namespace Backend;

public class Time
{
    //Fields
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;

    //Constructors
    public Time() { }

    public Time(int hour)
    {
        Hour = hour;
    }

    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
    }

    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public Time(int hour, int minute, int second, int millisecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
    }

    //Properties
    public int Hour
    {
        get => _hour;
        set
        {
            if (!ValidHour(value))
                throw new ArgumentException($"The hour: {value}, is not valid.");
            _hour = value;
        }
    }

    public int Minute
    {
        get => _minute;
        set
        {
            if (!ValidMinute(value))
                throw new ArgumentException($"The minute: {value}, is not valid.");
            _minute = value;
        }
    }

    public int Second
    {
        get => _second;
        set
        {
            if (!ValidSecond(value))
                throw new ArgumentException($"The second: {value}, is not valid.");
            _second = value;
        }
    }

    public int Millisecond
    {
        get => _millisecond;
        set
        {
            if (!ValidMillisecond(value))
                throw new ArgumentException($"The millisecond: {value}, is not valid.");
            _millisecond = value;
        }
    }
    //Methods
    public long ToMilliseconds()
    {
        return (long)_hour * 3_600_000 + _minute * 60_000 + _second * 1_000 + _millisecond;
    }

    public long ToSeconds()
    {
        return ToMilliseconds() / 1000;
    }

    public long ToMinutes()
    {
        return ToMilliseconds() / 60_000;
    }

    public Time Add(Time other)
    {
        int ms = _millisecond + other.Millisecond;
        int carryToSec = ms / 1000;
        ms %= 1000;

        int sec = _second + other.Second + carryToSec;
        int carryToMin = sec / 60;
        sec %= 60;

        int min = _minute + other.Minute + carryToMin;
        int carryToHour = min / 60;
        min %= 60;

        int hour = (_hour + other.Hour + carryToHour) % 24;

        return new Time(hour, min, sec, ms);
    }

    public bool IsOtherDay(Time other)
    {
        int ms = _millisecond + other.Millisecond;
        int carryToSec = ms / 1000;

        int sec = _second + other.Second + carryToSec;
        int carryToMin = sec / 60;

        int min = _minute + other.Minute + carryToMin;
        int carryToHour = min / 60;

        int hour = _hour + other.Hour + carryToHour;

        return hour >= 24;
    }

    public override string ToString()
    {
        string period = _hour < 12 ? "AM" : "PM";
        int hour12 = _hour % 12;

        return $"{hour12:00}:{_minute:00}:{_second:00}.{_millisecond:000} {period}";
    }

    //Private validations
    private bool ValidHour(int hour) => hour >= 0 && hour <= 23;
    private bool ValidMinute(int minute) => minute >= 0 && minute <= 59;
    private bool ValidSecond(int second) => second >= 0 && second <= 59;
    private bool ValidMillisecond(int millisecond) => millisecond >= 0 && millisecond <= 999;
}
