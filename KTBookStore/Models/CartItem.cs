using System.Collections.Generic;

namespace KTBook.Models
{
    
    public class CartItem
    {
        public int Id { get; set; } 
        public int Quantity {  get; set; }
        
        public int WaitCart_ID { get; set; }
        public Product product {  get; set; }
    }
}
