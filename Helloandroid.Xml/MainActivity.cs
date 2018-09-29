using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Helloandroid.Xml
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // ui
            SetContentView(Resource.Layout.activity_main);
            var aLabel = FindViewById<TextView>(Resource.Id.helloLabel);
            var aButton = FindViewById<Button>(Resource.Id.aButton);
            var resetButton = FindViewById<Button>(Resource.Id.resetButton);

            // button events
            aButton.Click += (sender, e) => {
                aLabel.Text = "Hello from the button";
            };

            resetButton.Click += (sender, e) => {
                aLabel.Text = GetString(Resource.String.helloLabelText);
            };
        }
    }
}