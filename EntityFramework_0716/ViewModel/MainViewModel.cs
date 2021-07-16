using EntityFramework_0716.Command;
using EntityFramework_0716.Model;
using EntityFramework_0716.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace EntityFramework_0716.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();
        public ObservableCollection<Author> Authors { get; set; } = new ObservableCollection<Author>();
        public ObservableCollection<Publisher> Publishers { get; set; } = new ObservableCollection<Publisher>();
        public RelayCommand AddCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        private Book _book;

        public Book Book
        {
            get { return _book; }
            set { _book = value; OnPropertyChanged(); }
        }
        


        public MainViewModel()
        {
            using ApplicationContext db = new ApplicationContext();

            //Book book = new Book() { Name = "C#" };
            //Books.Add(book);

            Author author1 = new Author()
            {
                Name = "Zaur",
                Surname = "Jafarov",
                BirthDate = new DateTime(2001, 06, 12)
            };
            Author author2 = new Author()
            {
                Name = "Ayxan",
                Surname = "Axundov",
                BirthDate = new DateTime(2001, 10, 06)
            };
            Authors.Add(author1);
            Authors.Add(author2);
            

            Publisher publisher1 = new Publisher()
            {
                Name = "StepIT",
                Address = "Koroglu Rahimov 70",
                EstablishDate = new DateTime(2020, 01, 01)
            };
            Publisher publisher2 = new Publisher()
            {
                Name = "Smth",
                Address = "Koroglu Rahimov 71",
                EstablishDate = new DateTime(2020, 02, 02)
            };
            Publishers.Add(publisher1);
            Publishers.Add(publisher2);

            AddCommand = new RelayCommand(
                (e) =>
                {

                });
            UpdateCommand = new RelayCommand(
                (e) =>
                {

                });
            DeleteCommand = new RelayCommand(
                (e) =>
                {

                });
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
