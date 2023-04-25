namespace webapi;

public class Dealer2 : Dealer
{
    public string? getStatus => Status ? "Active" : "Inactive";
}
