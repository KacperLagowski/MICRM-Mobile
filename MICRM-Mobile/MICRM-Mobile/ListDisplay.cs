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
using SIML.CRMData;
using System.Data;

namespace MICRM_Mobile
{
    public class ListDisplay : ListActivity
    {
        
        
        EditText searchControl;
        public void Action()
        {
            searchControl = FindViewById<EditText>(Resource.Id.searchControl);
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
            
            ListView lv = (ListView)FindViewById(Resource.Id.MainList);
           

    }
             
    }
}