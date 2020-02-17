using System.Collections.Generic;
using UserData.Entity;


namespace Respository.respository
{
    public class UserRespository
    {
        public static List<UsersData> list = new List<UsersData>();
        static UserRespository()
        {
            list.Add(new UsersData("varshini", "Female", "16cse100", 11));
            list.Add(new UsersData("Rohini", "Female", "16cse71", 1));
            list.Add(new UsersData("Sumathi", "Female", "16cse110", 2));
            list.Add(new UsersData("Prathi", "Female", "16cse111", 3));

        }
        public IEnumerable<UsersData> GetUserDetails()
        {
            return list;
        }

    }
}
