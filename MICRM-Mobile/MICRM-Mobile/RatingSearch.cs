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
    [Activity(Label = "RatingSearch")]
    public class RatingSearch : Activity
    {
        Spinner Userspinner;
        Spinner Ratingspinner;
        Spinner Subjectspinner;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RatingSearch);
            
            //User spinner
            #region
            Userspinner = FindViewById<Spinner>(Resource.Id.ownerSpinner);

            Userspinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Userspinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.user_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            Userspinner.Adapter = adapter;
            #endregion

            //Rating spinner
            #region
            Ratingspinner = FindViewById<Spinner>(Resource.Id.ratingSpinner);

            Ratingspinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Ratingspinner_ItemSelected);
            var adapter2 = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.rating_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            Ratingspinner.Adapter = adapter2;
            #endregion

            //Subject spinner
            #region
            Subjectspinner = FindViewById<Spinner>(Resource.Id.subjectSpinner);

            Subjectspinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Subjectspinner_ItemSelected);
            var adapter3 = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.subject_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter3.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            Subjectspinner.Adapter = adapter3;
            #endregion
        }

        private void Subjectspinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner Subjectspinner = (Spinner)sender;
            string user = Subjectspinner.SelectedItem.ToString();
        }

        private void Ratingspinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner Ratingspinner = (Spinner)sender;
            string user = Ratingspinner.SelectedItem.ToString();
        }

        private void Userspinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner Userspinner = (Spinner)sender;
            string user = Userspinner.SelectedItem.ToString();
        }
    }
}