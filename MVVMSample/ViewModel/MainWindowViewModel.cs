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
        public Book[] Books { get; private set; }
        Book selectedBook;

        public MainWindowViewModel()
        {
            Books = Book.GetBooks();
        }

       
        public Book SelectedBook
        {
            get
            {
                return selectedBook;
            }

            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        
    }
}
