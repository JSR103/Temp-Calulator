using System;

using UIKit;

namespace tempCAL
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.AirTemp.ShouldReturn += (textField) => {
                textField.ResignFirstResponder();
                return true;                                        //BOTH OF THESE ARE 
                                                                    //IF YOU PUSH "RETURN"
            };                                                      //THE KEYBOARD GOES AWAY   
            this.Humidity.ShouldReturn += (textField) => {
                textField.ResignFirstResponder();
                return true;
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        partial void Switchone_ValueChanged(UISwitch sender)
        {
            bool setting;//var can be changed to bool 
            if (setting = sender.On)
            {
                SWone.SetState(setting, true);
                Humidity.Hidden = false;
            }
            else
            {
                SWone.SetState(setting, false);
                Humidity.Hidden = true;
            }
        }
        partial void SLDone_ValueChanged(UISlider sender)
        {
            int progress = (int)sender.Value;
            LBLone.Text = progress.ToString();
        }
        partial void SWone_TouchUpInside(UISwitch sender)
        {
            var controller = UIAlertController.Create("Humidity is Turning Off", null, UIAlertControllerStyle.ActionSheet);

            var yesAction = UIAlertAction.Create("Okay", UIAlertActionStyle.Destructive,// -----------------------Below 
                (action) =>
                {
                    string msg = this.Humidity.Text == ""
                      ? "Humidity was turned off"
                      : "The TexBox:" + this.Humidity.Text + " No Errors";

                    // Controller within a controller
                    var cancelAction = UIAlertAction.Create("Okay", UIAlertActionStyle.Cancel, null);// ------------Is a parameter passing to the create method

                    var controller2 = UIAlertController.Create("Humidity was turned off", msg, UIAlertControllerStyle.Alert);
                    controller2.AddAction(cancelAction);
                    this.PresentViewController(controller2, true, null);
                });//------------------------------------------------------------Above

            var noAction = UIAlertAction.Create("Nevermind", UIAlertActionStyle.Cancel, null);
            controller.AddAction(noAction);
            controller.AddAction(yesAction);

            var ppc = controller.PopoverPresentationController;
            if (ppc != null)
            {
                ppc.SourceView = sender;
                ppc.SourceRect = sender.Bounds;
            }

            PresentViewController(controller, true, null);
        }
        partial void BTNcal_TouchUpInside(UIButton sender)
        {
            double mNumber;
            double mNumber2;


            if (Humidity.Hidden != false)
            {
                mNumber2 = TemCal.ifColdWeather(Convert.ToDouble(AirTemp.Text), Convert.ToDouble(LBLone.Text));

                AirTemp.ResignFirstResponder();
                //Figure out how to show the results in the resultsLabel

                results.Text = mNumber2.ToString();

            }
            else if (Humidity.Hidden == false)
            {

                mNumber = TemCal.ifHotWeather(Convert.ToDouble(AirTemp.Text), Convert.ToDouble(Humidity.Text));
                Humidity.ResignFirstResponder();
                AirTemp.ResignFirstResponder();
                //Figure out how to show the results in the resultsLabel

                results.Text = mNumber.ToString();
            }
            else
            {
                results.Text = "Something went wrong";
            }

        }
    }
}