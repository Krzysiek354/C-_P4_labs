using Microsoft.EntityFrameworkCore;
using zadanie_lab5;



var context = new My_Context();


var dana = new Autors { Id=1, Name = "Adam", Surname = "Mickiewicz" };
dana.Book.Add(new Books() { Title="Pan Tadeusz",Year=1819 });

context.Autorss.Add(dana);
context.SaveChanges();



