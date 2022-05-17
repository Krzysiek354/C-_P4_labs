using Microsoft.EntityFrameworkCore;
using zajecia_5;


var context = new MyDbContext();


context.Database.EnsureCreated();
var myclient = new Client()
{
    Name = "Jann Nowak"
};

myclient.Orders.Add(new order()
{ Price=10m}
    );

context.Clients.Add(myclient) ;

context.SaveChanges();


foreach (var item in context.Clients.Include(x=>x.Orders).ToList())   // wyciaganie danych
{
    Console.WriteLine(item);
}

//class MyRepository    //nakladka na dane 
//{
//    private MyDbContext contextt;

//    public DbSet<Client> client;

//    public MyRepository()
//    {
//       client = 
//    }
//}

//DO Zrobienia !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//Biblioteka, podsumowanie baza z ksiazkami i autorami,