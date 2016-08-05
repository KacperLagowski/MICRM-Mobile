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
using SIML.CRMData;

namespace MICRM_Mobile
{
    public class Contact
    {

        public Contact (DataRow row)
        {
             ID = row.CRMToInt("ID");
             FirstName = row["FirstName"].ToString();
             LastName = row["LastName"].ToString();
             JobTitle = row["JobTitle"].ToString();
             FirmName = row["FirmName"].ToString();
             Email = row["Email"].ToString();
             TelephoneMobile = row["TelephoneMobile"].ToString();
             AddressHome = row["AddressHome"].ToString();
             AddressLine1 = row["AddressLine1"].ToString();
             AddressLine2 = row["AddressLine2"].ToString();
             AddressLine3 = row["AddressLine3"].ToString();
             City = row["City"].ToString();
             Country = row["Country"].ToString();
             Postcode = row["Postcode"].ToString();
        }
          
            
        public int ID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string FirmName { get; set; }
        public string Email { get; set; }
        public string TelephoneMobile { get; set; }
        public string AddressHome { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }


        public override string ToString()
        {
            return FirstName + " " + LastName + " ";
        }
    }
}