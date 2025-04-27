namespace OrderMenu.Models
{
    public class Menu
    {
        public int MenuItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public bool IsActive { get; set; }
        public string ItemCategory { get; set; }
    }
}
