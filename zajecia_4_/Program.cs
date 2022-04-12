using System.Data.SqlClient;
using zajecia_4_;

var context = new MyDbcContext();

//var transaction = context.Database.BeginTransaction(); //wiele operacji w jednej paczce jesli cos sie nie uda to cofnij operacje, jestem w stanie wykonać wstecz stan bazy jest zapisywany

//var result = context.Clients.ToList();

var client = new Client
{
    //IDClient = 1,
    Name = "dwd",
    Adress = "dwd",
    Balance = 0

};

// transaction.roolback;
//transaction.commit;

context.Clients.Add(client);

context.SaveChanges();

var resultt = context.Clients.ToList(); // daj cala tabele, generalnie filtrujemy i uzywamy linqu

var resulttt = context.Clients.Where(client => client.Balance == 0).ToArray(); // jak dopisze array to wymuszam pobranie danych

foreach (var item in resultt)
{
    Console.WriteLine(item.Name);
}

//var ctx = new NorthwindContext(); //migracja, scaffold

//var region = ctx.Region.ToArray();

