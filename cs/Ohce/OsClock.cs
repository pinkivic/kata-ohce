public interface IClock
{
    int GetCurrentHour();
}

public class OsClock : IClock
{
    public int GetCurrentHour()
    {
        var now = DateTime.Now;
        return now.TimeOfDay.Hours;
    }
}