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
    [Activity(Label = "Search Results")]
    public class SearchResults : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {   
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.SearchResults);
            int contactid = Intent.GetIntExtra("contactid", 0);
            CRMDataCommand dc = new CRMDataCommand("spMobileContact");
            dc.ParameterAdd("ContactID", contactid);
            DataRow row = dc.FillDataRow();
            
            
            int ID = contactid;
            string FirstName = row["FirstName"].ToString();
            string LastName = row["LastName"].ToString();
            string JobTitle = row["JobTitle"].ToString();
            string FirmName = row["FirmName"].ToString();
            string Email = row["Email"].ToString();
            string TelephoneMobile = row["TelephoneMobile"].ToString();
            string AddressHome = row["AddressHome"].ToString();
            string AddressLine1 = row["AddressLine1"].ToString();
            string AddressLine2 = row["AddressLine2"].ToString();
            string AddressLine3 = row["AddressLine3"].ToString();
            string City = row["City"].ToString();
            string Country = row["Country"].ToString();
            string Postcode = row["Postcode"].ToString();

            TextView firstname = FindViewById<TextView>(Resource.Id.firstnameTextView);

            TextView lastname = FindViewById<TextView>(Resource.Id.lastnameTextView);

            TextView email = FindViewById<TextView>(Resource.Id.emailTextView);

            TextView phone = FindViewById<TextView>(Resource.Id.phoneTextView);

            TextView address1 = FindViewById<TextView>(Resource.Id.address1TextView);

            TextView address2 = FindViewById<TextView>(Resource.Id.address2TextView);

            TextView address3 = FindViewById<TextView>(Resource.Id.address3TextView);

            TextView postcode = FindViewById<TextView>(Resource.Id.postcodeTextView);

            TextView tags = FindViewById<TextView>(Resource.Id.tagsTextView);

            TextView jobtitle = FindViewById<TextView>(Resource.Id.jobTextView);

            TextView company = FindViewById<TextView>(Resource.Id.companyTextView);

            firstname.Text = FirstName;
            lastname.Text = LastName;
            email.Text = Email;
            phone.Text = TelephoneMobile;
            jobtitle.Text = JobTitle;
            address1.Text = AddressLine1;
            address2.Text = AddressLine2;
            address3.Text = AddressLine3;
            postcode.Text = Postcode;
            company.Text = FirmName;




        }
        }
    }
