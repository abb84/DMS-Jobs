namespace webapi;

public class Dealer1: Dealer
{

    public string? getStatus => Status?"For Sale":"Inactive";

}
