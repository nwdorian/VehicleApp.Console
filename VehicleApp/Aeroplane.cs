namespace VehicleApp;
internal class Aeroplane : Vehicle
{
    public string? Company { get; set; }
    internal double KsToMw()
    {
        return KsToKw() / 1000;
    }
    protected override void PrintDetails()
    {
        Console.WriteLine($"Aeroplane details: Manufacturer: {Manufacturer}, Model: {Model}, Company: {Company} Ks: {Ks}, Mw: {KsToMw()}");
    }
}
