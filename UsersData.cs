using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserData.Entity
{
    public class UsersData
    {
       public string UserName { get; set; }
       public string Gender { get; set; }
       public string RollNumber { get; set; }
       public int Rank { get; set; }
       
      public UsersData(string userName,string gender,string rollNumber,int rank)
        {
            this.UserName = userName;
            this.Gender = gender;
            this.RollNumber = rollNumber;
            this.Rank = rank;
        }
    }
}
