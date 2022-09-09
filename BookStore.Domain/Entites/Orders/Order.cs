using System.ComponentModel.DataAnnotations.Schema;
using BookStore.Domain.Commons;
using BookStore.Domain.Entites.Users;
using BookStore.Domain.Enums;

namespace BookStore.Domain.Entites.Orders;

public class Order : Auditable
{
    public string Address { get; set; }
    
    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }  
    
    public OrderState OrderState { get; set; }
}