using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: later we will load from database
            yield return new Friend { FirstName = "Thomas", LastName = "Turbano" };
            yield return new Friend { FirstName = "Paula", LastName = "Dencro" };
            yield return new Friend { FirstName = "Kiko", LastName = "Grande" };
            yield return new Friend { FirstName = "Toku", LastName = "Tannavara" };
        }
    }
}
