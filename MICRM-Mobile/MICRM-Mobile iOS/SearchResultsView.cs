using Foundation;
using SIML.CRMData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MICRM_Mobile;
using UIKit;


namespace MICRM_Mobile_iOS
{
    public partial class SearchResultsView : UIViewController
    {
        
        public SearchResultsView (IntPtr handle) : base (handle)
        {
            
        }

        public void search()
        {
            List<Contact> contacts = new List<Contact>();
            List<String> searchterms = searchTextBox.Text.Split(' ').ToList();
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
                contacts.Add(new Contact(row));
            }
            searchTextBox.Text = String.Empty;
        }
    }
}