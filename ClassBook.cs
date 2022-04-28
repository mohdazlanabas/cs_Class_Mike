// CLASS & OBJECTS then CONSTRUCTORS

namespace cs_ClassGather
{
    class classBook
    {
        static void Main(string[] args)
        {
            // THIS IS ABOUT CLASSES OBJECTS AND METHODS

            Book book1 = new Book("Harry Potter", "JK ROwling", 400);
            Book book2 = new Book("Lord Of The Rings", "Tolkien", 700);

            /*book1.title = "Harry Potter";
            book1.author = "JK ROwling";
            book1.pages = 400;

            ClassBook book2 = new ClassBook();
            book2.title = "Lord Of The RIngs";
            book2.author = "Tolkien";
            book2.pages = 700;*/

            Console.WriteLine(book1.title);
        }
    }
}
