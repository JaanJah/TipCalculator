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
            subTotalValue.TextChanged += SubTotalValue_TextChanged;
            
        }

        private void SubTotalValue_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            CalculateTip();
        }

        private void SeekBar_ProgressChanged(object sender, SeekBar.ProgressChangedEventArgs e)
        {
            tipPercent.Text = e.Progress.ToString();
            CalculateTip();
            return;
        }

        /// <summary>
        /// Subtotal = x;
        /// tipPercent = tipPercent.Text;
        /// 
        /// Find TipAmount
        /// TipAmount = subtotal 100%
        ///                x     TipPercent
        /// </summary>
        private void CalculateTip()
        {
            var tipPercentCalced = 0;
            var tipAmount = 0;

            if (tipAmount == 0)
            {
                tipAmount = int.Parse(subTotalValue.Text) - tipPercentCalced;

                tipPercentCalced = int.Parse(subTotalValue.Text) / 100 * int.Parse(tipPercent.Text);
                tipAmount = int.Parse(tipAmountValue.ToString());

            }
        }
    }
}