using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
namespace HisoChek.Helpers
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://hisocheks-default-rtdb.firebaseio.com/");
    }
}
