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
        Spinner Subjecspinner;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RatingSearch);
            #region
            Userspinner = FindViewById<Spinner>(Resource.Id.ownerSpinner);

            Userspinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Userspinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.user_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            Userspinner.Adapter = adapter;
            #endregion
            Ratingspinner = FindViewById<Spinner>(Resource.Id.ratingSpinner);

            Ratingspinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Ratingspinner_ItemSelected);
            var adapter2 = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.rating_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            Userspinner.Adapter = adapter;

            Userspinner = FindViewById<Spinner>(Resource.Id.ownerSpinner);

            Userspinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Userspinner_ItemSelected);
            var adapter3 = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.user_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            Userspinner.Adapter = adapter;
        }

        private void Ratingspinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Userspinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner Userspinner = (Spinner)sender;

            string user = Userspinner.SelectedItem.ToString();
        }
    }
}