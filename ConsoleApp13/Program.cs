class Piece
{
    public string Name { get; set; }
    public string FIO { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    // Конструктор
    public Piece(string name, string fio, string genre, int year)
    {
        Name = name;
        FIO = fio;
        Genre = genre;
        Year = year;
    }

    // Деструктор
    ~Piece()
    {
        Console.WriteLine("Объект Piece уничтожен.");
        // Здесь можно добавить код для освобождения ресурсов, если это необходимо.
    }

    internal void Dispose()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта пьесы
        Piece Piece = new Piece("Вишневый сад", "Антон Чехов", "Комедия", 1903);

        // Вывод информации о пьесе
        Console.WriteLine("Название пьесы: " + Piece.Name);
        Console.WriteLine("Автор: " + Piece.FIO);
        Console.WriteLine("Жанр: " + Piece.Genre);
        Console.WriteLine("Год выпуска: " + Piece.Year);

        // Вызов деструктора 
        Piece.Dispose();
    }
}
