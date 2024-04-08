namespace TileShop.Domain.Entities;

public class Characteristics
{
    public int Id { get; set; }
    public double AvailableQuantity { get; set; }
    public string? TileType { get; set; }
    public string? SurfaceType { get; set; }
    public string? Country { get; set; }
    public string? Color { get; set; }
    public string? Shape { get; set; }
    public string? Material { get; set; }
    public string? Producer { get; set; }
    public int? WeightInKg { get; set; }
    public string? Format { get; set; }
    public int? ThicknessInMm { get; set; }
    public string? Series { get; set; }
    public string? Texture { get; set; }
    public double? PackageQuantity { get; set; }
    public string? Rectifier { get; set; }
    public int? Grade { get; set; }
    public string? Collection { get; set; }
}
