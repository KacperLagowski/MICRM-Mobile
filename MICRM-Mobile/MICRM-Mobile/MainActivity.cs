using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Uri = Android.Net.Uri;
using SIML.CRMData;


namespace MICRM_Mobile
{
    [Activity(Label = "MICRM-M", MainLauncher = true, Icon = "@drawable/crm")]
    public class MainActivity : Activity
    {
        Button login;
        TextView help;
        Spinner userspinner;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            CRMDataCommand dm = new CRMDataCommand();
            dm.ConnectionStringDescoveryEngine = new ConnectionStringProvider();
            SetContentView(Resource.Layout.Main);

            //controls declared in the region below:
            #region 
            ImageButton micrmButton = FindViewById<ImageButton>(Resource.Id.micrmButton);
            micrmButton.Click += micrmButton_Click;
            login = FindViewById<Button>(Resource.Id.loginButton);
            login.Click += Login_Click;
            userspinner = FindViewById<Spinner>(Resource.Id.userSpinner);
            userspinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(userspinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.user_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            userspinner.Adapter = adapter;

            #endregion
        }

        private void userspinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner userspinner = (Spinner)sender;
            string user = userspinner.SelectedItem.ToString();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                Android.Widget.Toast.MakeText(this, new CRMDataCommand("sp_SayHello").FillDataRow().CRMToString("Message"), ToastLength.Short).Show();
                StartActivity(typeof(Menu));
            }
            catch
            {
                Android.Widget.Toast.MakeText(this, "Check your VPN Connection!", ToastLength.Long).Show();
            }
        }

        private void micrmButton_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062482")));
        }
    }
}


