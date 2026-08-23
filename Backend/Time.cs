namespace Backend;

public class Time
{
    //Fields
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;

    //Constructors
    public Time(){}
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
    public Time(int hour, int minute, int secound, int millisecond)
    {
        _hour = hour;
        _minute = minute;
        _secoud = secound;
        _millisecond = millisecond;
    }

    //Methods

    //Private validations
    private bool ValidHour(int hour) => hour >= 0 && hour <= 23;
    private bool ValidMinute(int minute) => minute >= 0 && minute <= 59;
    private bool ValidSecond(int second) => second >= 0 && second <= 29;
    private bool ValidMillisecond(int millisecond) => millisecond >= 0 && millisecond <= 999;
}
