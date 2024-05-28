namespace VehicleApp;

internal interface IVehicle
{
    string Color { get; set; }
    double Ks { get; set; }
    string? Manufacturer { get; set; }
    string? Model { get; set; }
}