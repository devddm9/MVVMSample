using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSample.Model
{
    public class Book : INotifyPropertyChanged
    {
        string author;
        string title;

        public string Author {
            get { return author; }
            set {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        void OnPropertyChanged(string PropertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static Book[] GetBooks()
        {
            var result = new[] {
                new Book() { Author = " Лев Толстой", Title = "Война и мир " },
                new Book() { Author = " Лев Толстой2", Title = "Война и мир2 " },
                new Book() { Author = " Лев Толстой3", Title = "Война и мир3 " }
            };
            return result;
        }
    }
}
