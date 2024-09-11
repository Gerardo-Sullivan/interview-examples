namespace HostApp;

/// <summary>
/// Represents a type of schedule for a <see cref="Delivery"/>.
/// </summary>
public enum DeliveryScheduleType
{
    /// <summary>
    /// Represents a <see cref="Delivery"/> that is prepared upon the patron's request.
    /// </summary>
    OnRequest,

    /// <summary>
    /// Represents a <see cref="Delivery"/> that is prepared immediately.
    /// </summary>
    Immediate,

    /// <summary>
    /// Represents a <see cref="Delivery"/> that is prepared based on the targeted delivery time.
    /// </summary>
    DeliveryWindow
}