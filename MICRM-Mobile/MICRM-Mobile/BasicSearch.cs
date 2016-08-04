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

namespace MICRM_Mobile
{
    [Activity(Label = "BasicSearch")]
    public class BasicSearch : Activity
    {
        string[] contactitems;
        Button search;
        EditText searchControl;
        public int contactid;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            


            // Create your application here
            SetContentView(Resource.Layout.SimpleSearch);
            
            search = FindViewById<Button>(Resource.Id.searchButton);
            search.Click += Search_Click;
            searchControl = FindViewById<EditText>(Resource.Id.searchControl);
           
            
        }

        private void Search_Click(object sender, EventArgs e)
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

            contactitems = new string[] { contacts.Select(p => p.FirmName + ' ' + p.LastName).ToArray().ToString() };

            contactid = 566;
            Intent results = new Intent(this, typeof(SearchAction));
            results.PutExtra("contactid", contactid);
            results.PutStringArrayListExtra("contactitems", contactitems);
            StartActivity(typeof(SearchAction));
            //StartActivity(typeof(SearchResults));
        }
    }
    }
