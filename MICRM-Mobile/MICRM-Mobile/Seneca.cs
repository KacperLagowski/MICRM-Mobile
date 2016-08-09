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
using Uri = Android.Net.Uri;

namespace MICRM_Mobile
{
    [Activity(Label = "Seneca Contact List")]
    public class Seneca : Activity
    { 
        //Controls Created in region below
        #region
        Button mainoffice;
        Button thomasmobile;
        Button thomasoffice;
        Button smithmobile;
        Button smithoffice;
        Button elstonmobile;
        Button elstonoffice;
        Button borrowsmobile;
        Button borrowsoffice;
        Button wrightmobile;
        Button wrightoffice;
        Button taylormobile;
        Button tayloroffice;
        Button lagowskimobile;
        Button lagowskioffice;
        #endregion 

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Seneca);
            //Controls below
            #region
            mainoffice = FindViewById<Button>(Resource.Id.mainOffice);
            mainoffice.Click += mainoffice_Click;

            thomasmobile = FindViewById<Button>(Resource.Id.thomasMobile);
            thomasmobile.Click += thomasmobile_Click;

            thomasoffice = FindViewById<Button>(Resource.Id.thomasOffice);
            thomasoffice.Click += thomasoffice_Click;

            smithmobile = FindViewById<Button>(Resource.Id.smithMobile);
            smithmobile.Click += smithmobile_Click;

            smithoffice = FindViewById<Button>(Resource.Id.smithOffice);
            smithoffice.Click += smithoffice_Click;

            elstonmobile = FindViewById<Button>(Resource.Id.elstonMobile);
            elstonmobile.Click += elstonmobile_Click;

            elstonoffice = FindViewById<Button>(Resource.Id.elstonOffice);
            elstonoffice.Click += elstonoffice_Click;

            borrowsmobile = FindViewById<Button>(Resource.Id.borrowsMobile);
            borrowsmobile.Click += borrowsmobile_Click;

            borrowsoffice = FindViewById<Button>(Resource.Id.borrowsOffice);
            borrowsoffice.Click += borrowsoffice_Click;

            wrightmobile = FindViewById<Button>(Resource.Id.wrightMobile);
            wrightmobile.Click += wrightmobile_Click;

            wrightoffice = FindViewById<Button>(Resource.Id.wrightOffice);
            wrightoffice.Click += wrightoffice_Click;

            taylormobile = FindViewById<Button>(Resource.Id.taylorMobile);
            taylormobile.Click += taylormobile_Click;

            tayloroffice = FindViewById<Button>(Resource.Id.taylorOffice);
            tayloroffice.Click += tayloroffice_Click;

            lagowskimobile = FindViewById<Button>(Resource.Id.lagowskiMobile);
            lagowskimobile.Click += lagowskimobile_Click;

            lagowskioffice = FindViewById<Button>(Resource.Id.lagowskiOffice);
            lagowskioffice.Click += lagowskioffice_Click;
            #endregion
        }

        //Functionality of buttons inside region below
        #region
        private void lagowskioffice_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062482")));
        }

        private void lagowskimobile_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:07578878278")));
        }

        private void tayloroffice_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062466")));
        }

        private void taylormobile_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:07809659244")));
        }

        private void wrightoffice_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062478")));
        }

        private void wrightmobile_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:07793537762")));
        }

        private void borrowsoffice_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062461")));
        }

        private void borrowsmobile_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:07917403770")));
        }

        private void elstonoffice_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062470")));
        }

        private void elstonmobile_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:07475362236")));
        }

        private void smithoffice_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062468")));
        }

        private void smithmobile_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:07775724682")));
        }

        private void thomasoffice_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062480")));
        }

        private void thomasmobile_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:07469392164")));
        }

        private void mainoffice_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062450")));
        }

        #endregion
    }
}