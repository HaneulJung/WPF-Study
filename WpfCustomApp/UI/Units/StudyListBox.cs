using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCustomApp.UI.Units
{
    public class StudyListBox : ListBox
    {
        static StudyListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StudyListBox), new FrameworkPropertyMetadata(typeof(StudyListBox)));
        }

        public StudyListBox()
        {
            this.ItemsSource = GetUsers();
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

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new StudyListBoxItem();
        }
    }
}
