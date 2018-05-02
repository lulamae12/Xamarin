using System;

using UIKit;

namespace popuptest
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
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        string Text;

        public string getDialogText()
        {
            
            UIAlertView alert = new UIAlertView();
            alert.Title = "Title";//title of alert box
            alert.AddButton("OK");//button title
            alert.Message = "Please Enter a Value.";//text
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;//input
            alert.Clicked += (object s, UIButtonEventArgs ev) => {
                Text = alert.GetTextField(0).Text;
                UIAlertView alertText = new UIAlertView();
                alertText.Title = "Entered Text:";//title of alert box
                alertText.AddButton("OK");//button title
                alertText.Message = Text;//text
                alertText.Show();
                // handle click event here
                // user input will be in alert.GetTextField(0).Text;
            };
  
            alert.Show();
            return Text;
        }

        partial void UIButton226_TouchUpInside(UIButton sender)
        {
            Text = getDialogText();
        }

        partial void UIButton1323_TouchUpInside(UIButton sender)
        {
            UIAlertView popup = new UIAlertView();
            popup.Title = "Title";//title of alert box
            popup.AddButton("OK");//button title
            popup.Message = "hello world";//text
            popup.Clicked += (object s, UIButtonEventArgs ev) => {
                // handle click event here
                // user input will be in alert.GetTextField(0).Text;
            };

            popup.Show();
        }
    }
}