using Foundation;
using System;
using UIKit;

namespace MICRM_Mobile_iOS
{
    public partial class queryButton : UIButton
    {
        public queryButton(IntPtr handle) : base(handle)
        {
                TouchUpInside += QueryButton_TouchUpInside;

        }

        private void QueryButton_TouchUpInside(object sender, EventArgs e)
        {
            
        }
    }
}