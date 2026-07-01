namespace zhinnegBus.Models;

public class Skin
{
    public int Id { get; set; }
    public string SkinName { get; set; }
    public string Category { get; set; }
    public string ImgPath { get; set; }
    public bool IsUnlock { get; set; }
    public int CostPoint { get; set; }
    public string Tag { get; set; }
    public bool IsFree { get; set; }
    public decimal Price { get; set; }
    public int SaleCount { get; set; }
    public string PreviewImg { get; set; }
}