using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Model
{
     class User
     {
          private string phoneNumber;
          private string passWord;
          private string fullName;
          private string storeID;

          public User(string phoneNumber, string passWord, string fullName)
          {
               this.PhoneNumber = phoneNumber;
               this.PassWord = passWord;
               this.FullName = fullName;
          }

          public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
          public string PassWord { get => passWord; set => passWord = value; }
          public string FullName { get => fullName; set => fullName = value; }
          public string StoreID { get => storeID; set => storeID = value; }
     }
}
