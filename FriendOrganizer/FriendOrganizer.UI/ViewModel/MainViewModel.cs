using FriendOrganizer.Model;
using System.Collections.ObjectModel;
using FriendOrganizer.UI.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private string _selectFriend;
        public ObservableCollection<Friend> Friends { get; set; }

        private IFriendDataService _friendDataService;
        //INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public void Load()
        {
            var friends = _friendDataService.GetAll();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }

        }
             

        public string SelectFriend
        {
            get { return _selectFriend; }
            set
            {
                _selectFriend = value;
                OnPropertyChange();
            }
        }

        private void OnPropertyChange([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
