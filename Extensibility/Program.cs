using LinqBooks;
using Extensibility;

namespace CustomLINQ // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // 命名空间冲突，产生混淆
            // var books = from book in SampleData.Books
            //     where book.Price < 30
            //     select book.Title;
            // Console.WriteLine(ObjectDumper.Dump(books));
        }
    }
}