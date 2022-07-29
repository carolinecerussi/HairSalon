namespace HairSalon.Models
{
public class Client
{
public string ClientName {get;set;}
public int ClientId {get;set;}
public string PhoneNumber{get;set;}
public int StylistId {get;set;}
public virtual Stylist Stylist {get;set;}
}
}