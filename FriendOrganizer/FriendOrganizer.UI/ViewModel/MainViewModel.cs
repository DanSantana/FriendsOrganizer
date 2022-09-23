using FriendOrganizer.Model;
using System.Collections.ObjectModel;
using FriendOrganizer.UI.Data;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : VieModelBase
    {
        private string _selectFriend;
        public ObservableCollection<Friend> Friends { get; set; }

        private IFriendDataService _friendDataService;
      

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
    }
}
