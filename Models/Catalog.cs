namespace Test_Task.Models
{
    public class Catalog
    {
        public int CatalogId { get; set; }
        public string Name { get; set; }

        public int? ParentCatalogId { get; set; }
        public Catalog ParentCatalog { get; set; }

        public ICollection<Catalog> ChildCatalogs { get; set; }
    }
}
