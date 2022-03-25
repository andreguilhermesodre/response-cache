namespace ResponseCache.Domain.Entitites
{
    public class Product
    {
        public string Name { get; }
        public IEnumerable<string> Categories { get; }
        public string Ean13 { get; }

        public Product(string name, IEnumerable<string> categories, string ean13)
        {
            Name = name;
            Categories = categories;
            Ean13 = ean13;
        }
    }
}
