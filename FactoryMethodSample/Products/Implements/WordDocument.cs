using FactoryMethodSample.Products.Contracts;

namespace FactoryMethodSample.Products.Implements;

public class WordDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Word document.");
    }
}
