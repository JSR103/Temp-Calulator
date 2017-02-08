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

namespace tempCAL
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField AirTemp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BTNcal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Humidity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LBLone { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel results { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider SLone { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch SWone { get; set; }

        [Action ("BTNcal_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BTNcal_TouchUpInside (UIKit.UIButton sender);

        [Action ("SLDone_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SLDone_ValueChanged (UIKit.UISlider sender);

        [Action ("Switchone_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Switchone_ValueChanged (UIKit.UISwitch sender);

        [Action ("SWone_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SWone_TouchUpInside (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (AirTemp != null) {
                AirTemp.Dispose ();
                AirTemp = null;
            }

            if (BTNcal != null) {
                BTNcal.Dispose ();
                BTNcal = null;
            }

            if (Humidity != null) {
                Humidity.Dispose ();
                Humidity = null;
            }

            if (LBLone != null) {
                LBLone.Dispose ();
                LBLone = null;
            }

            if (results != null) {
                results.Dispose ();
                results = null;
            }

            if (SLone != null) {
                SLone.Dispose ();
                SLone = null;
            }

            if (SWone != null) {
                SWone.Dispose ();
                SWone = null;
            }
        }
    }
}