using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Project1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);



            EditText textInput = FindViewById<EditText>(Resource.Id.editText);
            Button checkButton = FindViewById<Button>(Resource.Id.check);
            Button resetButton = FindViewById<Button>(Resource.Id.reset);
            Button hintButton = FindViewById<Button>(Resource.Id.hint);
            Button result = FindViewById<Button>(Resource.Id.result);
            TextView hint = FindViewById<TextView>(Resource.Id.hint);
            TextView shuffedLetters = FindViewById<TextView>(Resource.Id.shuffledLetters);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}