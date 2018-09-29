using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace HelloAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            // Creates the user interface in code
            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            var aButton = new Button(this);
            var resetButton = new Button(this);
            var aLabel = new TextView(this);
            

            aButton.SetText(Resource.String.helloButtonText);
            aLabel.SetText(Resource.String.helloLabelText);
            resetButton.SetText(Resource.String.resetButtonText);

            // button events
            aButton.Click += (sender, e) => {
                // set label
                aLabel.Text = "Hello from the button";
            };

            resetButton.Click += (sender, e) => {
                // reset label
                aLabel.Text = GetString(Resource.String.helloLabelText);
            };


            layout.AddView(aButton);
            layout.AddView(aLabel);
            layout.AddView(resetButton);
            SetContentView(layout);
        }
    }
}