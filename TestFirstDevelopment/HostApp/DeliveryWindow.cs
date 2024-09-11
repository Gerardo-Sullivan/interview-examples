namespace HostApp;

/// <summary>
/// Represents a targeted time for a <see cref="Delivery"/> to be prepared.
/// </summary>
public class DeliveryWindow
{
    public string ShopId { get; set; }

    /// <summary>
    /// Gets or sets the description of the delivery window.
    /// </summary>
    /// <remarks>
    /// For example, "Express" or "Standard"
    /// </remarks>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the number of days a delivery must take to be prepared.
    /// </summary>
    /// <remarks>
    /// For example, a value of "2" indicates that the <see cref="Delivery"/> will need to be prepared in no more than 2 days.
    /// </remarks>

    public int Value { get; set; }
}