using System;

using TimeRegistratorUI;

namespace TimeRegistratorBusinessLogic
{
  /// <summary>
  /// Class contains the required data for time registration.
  /// </summary>
  public class TimeRegistratorData : ITimeRegistratorData
  {
    public TimeRegistratorData(DateTimeOffset startTime, DateTimeOffset endTime, string customerName)
    {
      CustomerName = customerName;
      StartTime = startTime;
      EndTime = endTime;
    }

    public string CustomerName { get; set; }
    public DateTimeOffset StartTime { get; }
    public DateTimeOffset EndTime { get; }

    public string Duration
    {
      get
      {
        return GetDuration(EndTime.Subtract(StartTime));

       
      }
    }

    /// <summary>
    /// Method to convert the time into appropriate string.
    /// </summary>
    public static string GetDuration(TimeSpan duration)
    {
      if (duration.TotalHours > 1)
        return duration.ToString("h\\:mm\\:ss");

      return duration.ToString("m\\:ss");
    }
  }
}
