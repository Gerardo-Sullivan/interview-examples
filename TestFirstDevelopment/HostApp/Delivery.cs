namespace HostApp;

/// <summary>
/// Represents a delivery of an online purchased order.
/// </summary>
public class Delivery
{
    /// <summary>
    /// Gets or sets the delivery window which will be used to calculate time of delivery.
    /// </summary>
    [Obsolete($"Deprecated JSON property kept for backwards compatibility. Use {nameof(DeliverySchedule.DeliveryWindow)} instead.")]
    public DeliveryWindow DeliveryWindow
    {
        get
        {
            return Schedule.DeliveryWindow;
        }
        set
        {
            Schedule.DeliveryWindow = value;
        }
    }

    /// <summary>
    /// Gets or sets the schedule type for this delivery.
    /// </summary>
    public DeliverySchedule Schedule { get; set; }
}