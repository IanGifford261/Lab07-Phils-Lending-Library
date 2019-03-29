using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PhilsLendingLibrary.Classes
{
    public class Library<T> : IEnumerable
    {
        T[] books = new T[1];
        int counter = 0;

        public void AddBook(T book)
        {
            if(counter == books.Length)
            {
                Array.Resize(ref books, (books.Length * 2));
            }
            books[counter++] = book;
        }

        public void RemoveBook(T book)
        {
            T[] tempArr = null;

        }








        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {
                yield return books[i];
                
            }
        }

        //MAGIC like amanda says
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
  

}
