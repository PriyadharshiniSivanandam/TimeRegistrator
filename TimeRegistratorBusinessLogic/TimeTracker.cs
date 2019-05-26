using System;

namespace TimeRegistratorBusinessLogic
{
  /// <summary>
  /// Class contains the logic to track the time during time registration.
  /// </summary>
  public class TimeTracker
  {
    private DateTimeOffset _startTime;

    private string _customerName;

    public bool Tracking { get; private set; }

    /// <summary>
    /// Returns Clock In Time.
    /// </summary>
    public DateTimeOffset StartTime
    {
      get
      {
        if (!Tracking)
        {
          throw new TimeTrackerException("There is no time registration in progress.");
        }

        return _startTime;
      }

      private set { _startTime = value; }
    }

    public string CustomerName
    {
      get { return _customerName; }

      private set { _customerName = value; }
    }

    /// <summary>
    /// Start Time registration.
    /// </summary>
    /// <returns></returns>
    public DateTimeOffset Start()
    {
      if (Tracking)
      {
        throw new TimeTrackerException("Time Registration already in progress.");
      }

      this.Tracking = true;
      this.StartTime = DateTimeOffset.Now;

      return this.StartTime;
    }

    /// <summary>
    ///Stop Time registration.
    /// </summary>
    public TimeRegistratorData Stop()
    {
      if (!Tracking)
      {
        throw new TimeTrackerException("There is no time registration started.");
      }

      this.Tracking = false;


      return new TimeRegistratorData(_startTime, DateTimeOffset.Now, this.CustomerName);
    }

    /// <summary>
    /// Time Tracker Exception
    /// </summary>
    public class TimeTrackerException : Exception
    {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="message"></param>
      public TimeTrackerException(string message) : base(message)
      {
      }
    }
  }
}
