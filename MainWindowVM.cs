using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace UMS1
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Person> persons;
        [ObservableProperty]
        public Person selectedUser = null;
        [ObservableProperty]
        public Person defaultPerson = null;

        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }

        [RelayCommand]
        public void RemovePerson()
        {
            if (selectedUser != null)
            {
                string name = selectedUser.FirstName;
                persons.Remove(selectedUser);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED");

            }
            else
            {
                MessageBox.Show("Plese Select Student before Delete.", "Error");
            }
        }

        [RelayCommand]
        public void details()
        {
            if (selectedUser != null)
            {
                var vm=new DetailsWindowVM(selectedUser);
                DetailsWindow window = new DetailsWindow(vm);
                window.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Select a student to get the details.", "Error");
            }
        }

        [RelayCommand]
        public void add()
        {
            var vm= new EditWindowVM();
            var window = new EditWindow(vm);
            window.ShowDialog();

            persons.Add(vm.Student);
        }

        [RelayCommand]
        public void edit()
        {
            if (selectedUser != null)
            {
                var vm = new EditWindowVM(selectedUser);
                var window = new EditWindow(vm);
                window.ShowDialog();

                int index = persons.IndexOf(selectedUser);
                persons.RemoveAt(index);
                persons.Insert(index, vm.Student);

            }
            else
            {
                MessageBox.Show("Please Select a student to get the details.", "Error");
            }
        }
        
        //public MainWindowVM()
        //{
        //    persons = new ObservableCollection<Person>()
        //    {
        //        //BitmapImage image1; 
        //        //image1 = new BitmapImage(new Uri("/Model/Images/1.png", UriKind.Relative));
        //        //new Person("Shavidika","Ekanayake","31/05/1999",image1,3.5,"shavidika.ekanayake@gmail.com","Undergraduate student of University of Ruhuna."),
        //        //new Person("Wathmi","Thennakoon","20/09/2000",image2,5,"wathmi.vihanga@gmail.com","Undergraduate student of University of Moratuwa."),
        //        //new Person("Shavidini","Ekanayake","31/05/1999","3.png",3.5,"shavidini.ekanayake@gmail.com","Undergraduate student of SLIIT."),
        //        //new Person("Thameera","Ekanayake","28/10/1987","4.png",3.5,"thameera.ekanayake@gmail.com","Human Resource manager of Seedevi Holdings."),
        //        //new Person("Thameera","Ekanayakeeeeeeeeeeeeee","28/10/1987","4.png",3.5,"thameera.ekanayake@gmail.com","Human Resource manager of Seedevi Holdings."),
        //        //new Person("Thameera","Ekanayake","28/10/1987","4.png",3.5, "thameera.ekanayake@gmail.com", "Human Resource manager of Seedevi Holdings."),
        //        //new Person("Thameera","Ekanayake","28/10/1987","4.png",3.5, "thameera.ekanayake@gmail.com", "Human Resource manager of Seedevi Holdings."),
        //        //new Person("Harshani","Ekanayake","14/02/1985","5.png",3.5,"harshani.ekanayake@gmail.com","Teacher at Anuradhapura Central College.")
        //    };
        //}

        public MainWindowVM()
        {
            persons = new ObservableCollection<Person>();
            BitmapImage image1 = new BitmapImage(new Uri("/Images/shavidika ekanayake.jpg", UriKind.Relative));
            persons.Add(new Person("Shavidika", "Ekanayake", "31/05/1999", image1, 3.5, "shavidika.ekanayake@gmail.com", "Undergraduate student of University of Ruhuna."));
            BitmapImage image2 = new BitmapImage(new Uri("Images/2.png", UriKind.Relative));
            persons.Add(new Person("Wathmi", "Thennakoon", "20/09/2000", image2, 5, "wathmi.vihanga@gmail.com", "Undergraduate student of University of Moratuwa."));
            BitmapImage image3 = new BitmapImage(new Uri("Images/3.png", UriKind.Relative));
            persons.Add(new Person("Shavidini", "Ekanayake", "31/05/1999", image3, 3.5, "shavidini.ekanayake@gmail.com", "Undergraduate student of SLIIT."));
            BitmapImage image4 = new BitmapImage(new Uri("Images/4.png", UriKind.Relative));
            persons.Add(new Person("Thameera", "Ekanayake", "28/10/1987", image4, 3.5, "thameera.ekanayake@gmail.com", "Human Resource manager of Seedevi Holdings."));
            BitmapImage image5 = new BitmapImage(new Uri("Images/4.png", UriKind.Relative));
            persons.Add(new Person("Mahinda", "Ekanayake", "05/12/1957", image5, 3.5, "mahinda.ekanayake@gmail.com", "CEO at Ekanyake Travels"));
            BitmapImage image6 = new BitmapImage(new Uri("Images/4.png", UriKind.Relative));
            persons.Add(new Person("Kumari", "Ekanayake", "28/11/1957", image6, 3.5, "kumari.ekanayake@gmail.com", "Official agent at Sathwin tours."));
            BitmapImage image7 = new BitmapImage(new Uri("Images/4.png", UriKind.Relative));
            persons.Add(new Person("Harshani", "Ekanayake", "14/02/1985", image7, 3.5, "harshani.ekanayake@gmail.com", "Teacher at Anuradhapura Central College."));
            BitmapImage image8 = new BitmapImage(new Uri("Images/4.png", UriKind.Relative));
            persons.Add(new Person("Dilini", "Senanayake", "23/10/1986", image8, 3.5, "dilini.senanayake@gmail.com", "Teacher at Anuradhapura Central College."));

        }


    }
}
