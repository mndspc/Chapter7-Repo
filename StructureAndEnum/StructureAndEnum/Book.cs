using System;

namespace StructureAndEnum
{
    //  Struct is user defined data type.it can contain different types but it's a value type
    struct Book
    {
        //  Struct does not allow to override to create shadow of default constructor
        //public Book()
        //{

        //}

        static Book()
        {
            Console.WriteLine("Static constructor of Book");
        }

        //  Global field members
        //int isbn;
        //string bookName;
        //string authorName;

        //  Properties 
        public int isbn { get; set; }
        public string bookName { get; set; }
        public string authorName { get; set; }

        public Book(int isbn,string bookName,string authorName)
        {
            this.isbn = isbn;
            this.bookName = bookName;
            this.authorName = authorName;
        }
        public string Display()
        {
            return string.Format("ISBN={0} Book Name={1} Author Naame={2}",isbn,bookName,authorName);
        }
    }
}
