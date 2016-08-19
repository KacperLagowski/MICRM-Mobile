// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MICRM_Mobile_iOS
{
    [Register ("SearchResultsView")]
    partial class SearchResultsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MICRM_Mobile_iOS.queryButton queryButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField searchTextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MICRM_Mobile_iOS.MainTable tableResults { get; set; }

        [Action (" b:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void  b (MICRM_Mobile_iOS.queryButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (queryButton != null) {
                queryButton.Dispose ();
                queryButton = null;
            }

            if (searchTextBox != null) {
                searchTextBox.Dispose ();
                searchTextBox = null;
            }

            if (tableResults != null) {
                tableResults.Dispose ();
                tableResults = null;
            }
        }
    }
}