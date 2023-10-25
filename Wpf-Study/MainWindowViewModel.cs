using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Wpf_Study
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<User> _users;

        public MainWindowViewModel()
        {
            Users = GetUsers();
        }

        private List<User> GetUsers()
        {
            List<User> users = new List<User>();

            users.Add(new User("Cielo", "30"));
            users.Add(new User("Cielo2", "31"));
            users.Add(new User("Cielo3", "32"));

            return users;
        }

        public class User
        {
            public string Name { get; set; }
            public string Age { get; set; }

            public User(string name, string age)
            {
                Name = name;
                Age = age;  
            }
        }
    }   
}
