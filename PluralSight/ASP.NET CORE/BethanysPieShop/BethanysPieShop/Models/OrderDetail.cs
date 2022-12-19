using System.ComponentModel.DataAnnotations.Schema;

namespace BethanysPieShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        [ForeignKey("OrderId")]
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Pie Pie { get; set; }
        public int PieId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}
