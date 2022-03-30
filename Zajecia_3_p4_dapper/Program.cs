// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using Dapper;


string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Northwind2;Integrated Security=True;Pooling=False";
SqlConnection connection = new SqlConnection(connectionString);




//var insertResult = connection.Execute("INSERT INTO Region(RegionID,RegionDescription) Values (@,@Description)",
//    new { 
//        Id = 13,
//        Description = "TestAnon"
//        }
//    );//przez parametr typ anonimowy ALBO ponizej

var regionToInsert = new Region() // obiekt do parametru
{
    RegionId = 15,
    RegionDescription = "testregionn"
};

//var insertResult = connection.Execute("INSERT INTO Region(RegionID,RegionDescription) Values (@RegionId,@RegionDescription)", 
// regionToInsert
//    );//przez parametr, nazwy jak w obiekcie regionToInsert


var result = connection.Query<Region>("SELECT * FROM dbo.[Region]"); //queryfirst jednego goscia pobiera, querysingle pobira jeden wiersz



//foreach (var item in result)
//{
//    Console.WriteLine($"{item.RegionId}: {item.RegionDescription}");
//}


///////////////////////////////////////////////////////////////////////////////////////////////
///JOINY
///

//var joinResult = connection.Query<Product, Category, Product>("SELECT * FROM Products p JOIN Categories c on p.CategoryID = c.CategoryId",
//    (product, category) =>
//    {

//        product.Category = category;
//        return product;
//    },
//    splitOn: "CategoryId"
//    );

//foreach (var item in joinResult)
//{
//    Console.WriteLine($"{item.ProductName} : {item.Category.CategoryName}");
//}




var joinResult_1 = connection.Query<Territories, Region, Territories>("SELECT * FROM Territories as t inner join Region as r on t.RegionID = r.RegionID WHERE t.TerritoryDescription like 'E%'",
    (tterytor, reg) =>
    {
        tterytor.Region = reg;
        return tterytor;
    },
    splitOn: "RegionID"
    );

foreach (var item in joinResult_1)
{
    Console.WriteLine($"{item.TerritoryID}:     {item.TerritoryDescription}: {item.Region.RegionId} :{item.Region.RegionDescription}");
    Console.WriteLine();
}