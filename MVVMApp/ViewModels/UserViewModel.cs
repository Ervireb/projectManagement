using MVVMApp.Models;
using MVVMApp.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MVVMApp.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private readonly UserService _userService;
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        // Конструктор, принимающий UserService
        public UserViewModel(UserService userService)
        {
            _userService = userService;
            LoadUsers();
        }

        // Конструктор по умолчанию
        public UserViewModel() : this(new UserService()) { }

        private async void LoadUsers()
        {
            var users = await _userService.GetUsersAsync();
            Users = new ObservableCollection<User>(users);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
