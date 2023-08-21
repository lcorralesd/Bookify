using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Shared;
public record Currency
{
    internal static readonly Currency None = new("");
    public static readonly Currency USD = new("USD");
    public static readonly Currency EUR = new("EUR");

    private Currency(string code) => Code = code;

    public string Code { get; init; }

    //public static Currency FromCode(string code)
    //{
    //    return code switch
    //    {
    //        "USD" => USD,
    //        "EUR" => EUR,
    //        _ => throw new ArgumentException($"Unknown currency code: {code}")
    //    };
    //}

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code)
            ?? throw new ApplicationException($"Unknown currency code: {code}");
    }

    public static IReadOnlyCollection<Currency> All => new[] { USD, EUR };
}
