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

namespace MICRM_Mobile
{
    [Activity(Label = "SearchAction")]
    public class SearchAction : ListActivity
    {
        //string[] contactitems;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            List<Contact> contacts = new List<Contact>();
            base.OnCreate(savedInstanceState);
            string[] contactitems = Intent.GetStringArrayExtra("contactitems");
            int contactid = Intent.GetIntExtra("contactid", 0);
            // Create your application here
            SetContentView(Resource.Layout.SearchAction);
            
            ListView lv = (ListView)FindViewById(Resource.Id.list);
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, contactitems);
           
        }
    }
}