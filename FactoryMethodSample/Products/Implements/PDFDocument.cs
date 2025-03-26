using FactoryMethodSample.Products.Contracts;

namespace FactoryMethodSample.Products.Implements;
public class PDFDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening PDF document.");
    }
}
