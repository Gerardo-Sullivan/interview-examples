using FluentAssertions;
using HostApp;
using Newtonsoft.Json;

namespace Connect.WebClient.UnitTests.OrderSerialization;

[TestClass]
public class DeliverySerializationTests
{
    [TestMethod]
    public void BackwardsCompatibility_OnRequestDelivery()
    {
        // JSON structure prior to some refactoring of the C# model
        const string oldJsonDelivery = """
{
    "deliveryWindow": null,
    "StartPreparationOnOrderCompletion": false
}
""";
        var delivery = JsonConvert.DeserializeObject<Delivery>(oldJsonDelivery);

        delivery.Schedule.Type.Should().Be(DeliveryScheduleType.OnRequest);
        delivery.Schedule.DeliveryWindow.Should().BeNull();
    }

    [TestMethod]
    public void BackwardsCompatibility_ImmediateDelivery()
    {
        // JSON structure prior to some refactoring of the C# model
        const string oldJsonDelivery = """
{
    "deliveryWindow": null,
    "StartPreparationOnOrderCompletion": true
}
""";
        var delivery = JsonConvert.DeserializeObject<Delivery>(oldJsonDelivery);

        delivery.Schedule.Type.Should().Be(DeliveryScheduleType.Immediate);
        delivery.Schedule.DeliveryWindow.Should().BeNull();
    }

    [TestMethod]
    public void BackwardsCompatibility_DeliveryWindowDelivery()
    {
        // JSON structure prior to some refactoring of the C# model
        const string jsonDelivery = """
{
    "deliveryWindow": {
        "cinemaId": "0001",
        "description": "Express",
        "value": 2
    },
    "StartPreparationOnOrderCompletion": false
}
""";
        var delivery = JsonConvert.DeserializeObject<Delivery>(jsonDelivery);

        delivery.Schedule.Type.Should().Be(DeliveryScheduleType.DeliveryWindow);
        delivery.Schedule.DeliveryWindow.Should().BeEquivalentTo(new DeliveryWindow
        {
            ShopId = "0001",
            Description = "Express",
            Value = 15
        });
    }
}