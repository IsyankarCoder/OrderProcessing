namespace Models
{
    public class Order
    {
       public int Id{get;set;}
       public string CustomerName{get;set;}="";
       public decimal TotalAmount{get;set;}
       public string  ProductName{get;set;}="";

       public int Quantity{get;set;}

       public bool IsPaid{get;set;}
       public bool IsShipped{get;set;}

    }
}