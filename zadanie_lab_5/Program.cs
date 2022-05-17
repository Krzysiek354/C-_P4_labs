using Microsoft.EntityFrameworkCore;
using zadanie_lab_5;

var context = new My_Context();
if (!context.Database.EnsureCreated()) Console.WriteLine("BAZA ISTNIEJE");
else Console.WriteLine("BAZA ZOSTALA STWORZONA");

//var dana = new Autors { Name = "Adam", Surname = "Mickiewicz" };
//dana.Book.Add(new Books() { Title = "Pan Tadeusz", Year = 1819 });

//context.Autors.Add(dana);
//context.SaveChanges();

string zm;
string autor;
string ksiazka;



while (true)
{

    Console.WriteLine("BAZA KSIAZEK I AUTOROW");
    Console.WriteLine("1. Dodaj dane");
    Console.WriteLine("2. Szukaj Autora");
    Console.WriteLine("3. Szukaj Książki");
    Console.WriteLine("4. Koniec Programu");
    zm = Console.ReadLine();



    if (zm == "1")
    {
        var data = new Autors();
        var data_book = new Books();
        Console.WriteLine("DODAWANIE DANYCH:");
        Console.WriteLine("Autor Imie:");
        data.Name = Console.ReadLine();
        Console.WriteLine("Autor Nazwisko:");
        data.Surname = Console.ReadLine();
        Console.WriteLine("Ksiazka Tytul:");
        data_book.Title = Console.ReadLine();
        Console.WriteLine("Ksiazka Rok:");
        data_book.Year =  Convert.ToInt32(Console.ReadLine());
        data.Book.Add(data_book);

        context.Autors.Add(data);
        context.SaveChanges();

        Console.ReadKey();
    }
    else if (zm == "2")
    {
        Console.WriteLine("SZUKASZ AUTORA Nazwisko:");
        autor = Console.ReadLine();
        var aut0r = context.Autors.Include(x=>x.Book);
        
     
        
        Console.WriteLine("Wyniki:");
       
      
        
            foreach (var item in aut0r.Where(x=>x.Surname==autor))
            {
                foreach (var it in item.Book)
                {
                    Console.WriteLine($"{it.Autor.Name} {it.Autor.Surname}  {it.Title}  {it.Year}");
                }
            }

        



        Console.ReadKey();
    }
    else if (zm == "3")
    {
        Console.WriteLine("SZUKASZ KSIAZKI Tytul:");

       
        ksiazka = Console.ReadLine();
        var b00k = context.Books.Include(x => x.Autor).ToArray();



        Console.WriteLine("Wyniki:");

            foreach (var item in b00k.Where(x => x.Title == ksiazka))
            {
                Console.WriteLine($"{item.Title} { item.Year}");
            }

        

        Console.ReadKey();

    }
    else if (zm == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Niepoprawny wybor");
        Console.ReadKey();
    }
    System.Console.Clear();
}