using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Recurring
{
    public string Periodicity { get; set; }
    public string Interval { get; set; }
    public string NextPayment { get; set; }
    public int MaxPeriods { get; set; }

    [JsonPropertyName("dueDate ")]
    public string DueDate { get; set; }

    [JsonPropertyName("notificationUrl ")]
    public string NotificationUrl { get; set; }
}
