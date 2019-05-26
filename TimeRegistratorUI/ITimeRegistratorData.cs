using System;

namespace TimeRegistratorUI
{
  /// <summary>
  /// Interface contains the required data for time registration.
  /// </summary>
  public interface ITimeRegistratorData
  {
    /// <summary>
    /// Name of the Customer.
    /// </summary>
    string CustomerName { get; set; }

    /// <summary>
    /// Starting time of the registration.
    /// </summary>
    DateTimeOffset StartTime { get; }

    /// <summary>
    /// End time of the registration.
    /// </summary>
    DateTimeOffset EndTime { get; }

    /// <summary>
    /// Duration from Start to End of the registration.
    /// </summary>
    string Duration { get; }
  }
}
