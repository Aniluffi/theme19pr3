using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Book:IComparison<Book>
    {
       public string Name { get; set; }
       public int Coast { get; set; }

        public Book(string name, int coast)
        {
            this.Name = name;
            this.Coast = coast;
        }

        public Book()
        {

        }

        public  List<Book> TypeComparison(List<Book> objects)
        {
            
            return objects.OrderBy(book => book.Name).ToList(); ;
        }
    }
}
