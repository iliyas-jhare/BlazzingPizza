namespace BlazingPizza.Extensions;

public static class DecimalEx
{
    public static string ToFormattedPrice(this decimal source) => source.ToString("0.00");
}
