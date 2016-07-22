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
    [Activity(Label = "Seneca")]
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

            // Create your application here

            SetContentView(Resource.Layout.Seneca);

            //events for buttons, all the same
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

            elstonoffice = FindViewById<Button>(Resource.Id.els);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            usernameText = FindViewById<Button>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;

            #endregion
        }

        private void mainoffice_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}