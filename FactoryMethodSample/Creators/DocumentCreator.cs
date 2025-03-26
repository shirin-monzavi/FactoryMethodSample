namespace FactoryMethodSample.Creators;

public class DocumentCreator<TDocument> where TDocument : class, new()
{
    public TDocument CreateDocument()
    {
        return new TDocument();
    }
}
