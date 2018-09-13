using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace TipCalculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView tipPercent;
        EditText subTotalValue;
        TextView tipAmountValue;
        TextView totalValue;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            tipPercent = FindViewById<TextView>(Resource.Id.tipPercent);
            var seekBar = FindViewById<SeekBar>(Resource.Id.seekBar1);
            subTotalValue = FindViewById<EditText>(Resource.Id.subTotalValue);
            tipAmountValue = FindViewById<TextView>(Resource.Id.tipAmountValue);
            totalValue = FindViewById<TextView>(Resource.Id.totalValue);

            seekBar.ProgressChanged += SeekBar_ProgressChanged;

            var calculateTip = 0;
            var calculateTotal = 0;
        }

        private void SeekBar_ProgressChanged(object sender, SeekBar.ProgressChangedEventArgs e)
        {
            tipPercent.Text = e.Progress.ToString();
            return;
        }
    }
}