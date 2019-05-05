using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSample.Model;

namespace MVVMSample.ViewModel
{

    /// <summary>
    /// 
    /// </summary>
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        Book[] books;

        //public MainWindowViewModel(Book[] books)
        //{
        //    this.books = books;
        //}

        public Book[] Books { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        public static Book[] GetBooks() {
            var result = new[] {
                new Book() { Author = " Лев Толстой", Title = "Война и мир " },
                new Book() { Author = " Лев Толстой2", Title = "Война и мир " },
                new Book() { Author = " Лев Толстой3", Title = "Война и мир " }
            };
            return result;
        }
    }
}
