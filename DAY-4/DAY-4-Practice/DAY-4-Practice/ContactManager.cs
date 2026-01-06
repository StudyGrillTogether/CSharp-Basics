using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_Practice
{
    public class ContactManager
    {
        //our list is inside the class now
        public List<contact> MyFriends=new List<contact>();

        //this method handles the search logic we built
        public contact findbyname(string targetname)
        {
            foreach(contact c in MyFriends)
            {
                if(c.Name==targetname){
                    return c;//returns the found contact and stops

                }
            }
            return null; //if not found
        }

    }
}
