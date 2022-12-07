namespace IWantApp.Domain.Products
{
    public class Category : Entity
    {
       
        public string Name { get; set; }
        public bool Active { get; set; } = true;
        public bool IsValid { get; internal set; }
        public object Notifications { get; internal set; }
    }
}
