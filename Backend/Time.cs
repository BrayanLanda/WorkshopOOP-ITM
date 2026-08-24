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
        _hour = hour;
    }
    public Time(int hour, int minute)
    {
        _hour = hour;
        _minute = minute;
    }
    public Time(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
    }
    public Time(int hour, int minute, int second, int millisecond)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
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

    //Private validations
    private bool ValidHour(int hour) => hour >= 0 && hour <= 23;
    private bool ValidMinute(int minute) => minute >= 0 && minute <= 59;
    private bool ValidSecond(int second) => second >= 0 && second <= 29;
    private bool ValidMillisecond(int millisecond) => millisecond >= 0 && millisecond <= 999;
}
