namespace RicardoQuintanaTaller2MVC.Models
{
    public class Promo
    {
        public int PromoId { get; set; }   
        public string? PromoName { get; set;}
        public string? PromoDescripcion { get; set; }
        public int id { get; set; } 
        public Burger? Burger { get; set; } 
    }
}
