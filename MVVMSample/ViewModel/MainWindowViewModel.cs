using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMSample.Model;

namespace MVVMSample.ViewModel
{

    /// <summary>
    /// 
    /// </summary>
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        Book[] books;
        public ObservableCollection<Book> Books { get; private set; }
        Book selectedBook;

        public MainWindowViewModel()
        {
            Books = new ObservableCollection<Book>(Book.GetBooks());
            AddCommand = new DelegateCommand(AddBook);
            RemoveCommand = new DelegateCommand(RemoveBook,CanRemoveBook);
        }

        bool CanRemoveBook(object arg)
        {
            return (arg as Book) != null;
        }

        void AddBook(object obj)
        {
            Books.Add(new Model.Book { Author = "Тест", Title = "Все все равно" });
        }

        void RemoveBook(object obj)
        {
            Books.Remove((Book)obj);
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

        public ICommand AddCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        
    }
}
