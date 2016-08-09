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
using Android.Graphics;
using SIML.CRMData;
using System.Data;
using static Android.Widget.AdapterView;

namespace MICRM_Mobile
{
    [Activity(Label = "Contact Search")]
    public class BasicSearch : Activity
    {
        string[] contactitems;
        Button search;
        EditText searchControl;
        public int contactid;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SimpleSearch);
            ListView lv = (ListView)FindViewById(Resource.Id.MainList);
            search = FindViewById<Button>(Resource.Id.searchButton);
            search.Click += Search_Click;
            searchControl = FindViewById<EditText>(Resource.Id.searchControl);
            lv.ItemClick += new EventHandler<ItemClickEventArgs>(ffff);
        }
        private void ffff(object sender, ItemClickEventArgs e)
        {
            ListView lv = (ListView)FindViewById(Resource.Id.MainList);
            Contact contact = lv.GetItemAtPosition(e.Position).Cast<Contact>();
            Intent results = new Intent(this, typeof(SearchResults));
            results.PutExtra("contactid", contact.ID);   
            StartActivity(results);
        }
        public void Search_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = new List<Contact>();
            List<String> searchterms = searchControl.Text.Split(' ').ToList();
            while (searchterms.Count < 3)
            {
                searchterms.Add(String.Empty);
            }
            CRMDataCommand dc = new CRMDataCommand("spMobileSearch");
            dc.ParameterAdd("SearchTerm1", searchterms[0]);
            dc.ParameterAdd("SearchTerm2", searchterms[1]);
            dc.ParameterAdd("SearchTerm3", searchterms[2]);
            DataTable dt = dc.FillDataTable();
            foreach (DataRow row in dt.Rows)
            {
                contacts.Add(new MICRM_Mobile.Contact(row));
            }
            ArrayAdapter<Contact> contactsAdapter =
            new ArrayAdapter<Contact>(this, Android.Resource.Layout.SimpleListItem1, contacts);
            ListView lv = (ListView)FindViewById(Resource.Id.MainList);
            lv.SetAdapter(contactsAdapter);
        }
    }
    }
