
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data;

namespace MICRM_Mobile
{
    class Account
    {
        public Account(DataRow dr)
        {
            UserName = dr["UserName"].ToString();
            Date = dr["Date"].ToString();
        }
        string UserName { get; set; }
        string Date { get; set; }
    }
}