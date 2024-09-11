namespace HostApp;

/// <summary>
/// Represents a preparation schedule for <see cref="Delivery"/>.
/// </summary>
/// <remarks>
/// For example, "Immediate" or "On Request"
/// </remarks>
public class DeliverySchedule
{
    public required DeliveryScheduleType Type { get; init; }

    /// <summary>
    /// Gets or sets the window detailing when the delivery will complete.
    /// </summary>
    /// <remarks>
    /// Only applicable, for <see cref="DeliverySchedule"/> of type <see cref="DeliveryScheduleType.DeliveryWindow"/>
    /// </remarks>
    public DeliveryWindow DeliveryWindow { get; set; }
}