namespace MODULE1GENERIC
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return $"ProductId: {ProductId}, ProductName: {ProductName}";
        }
    }
}
