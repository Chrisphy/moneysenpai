
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace moneysenpai
{
    [Activity(Label = "loan_calculator")]
    public class loan_calculator : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.loan_calculator);


            TextView textView = FindViewById<TextView>(Resource.Id.textview_loan);




            Button calc = FindViewById<Button>(Resource.Id.calculate_loan_button);


            calc.Click += delegate
            {

                int mortage = Convert.ToInt32((FindViewById<EditText>(Resource.Id.mortage_input)).Text);

                int loanterm = Convert.ToInt32((FindViewById<EditText>(Resource.Id.loanterm_input)).Text);

                int interest = Convert.ToInt32((FindViewById<EditText>(Resource.Id.interest_input)).Text);

                int repayment = Convert.ToInt32((FindViewById<EditText>(Resource.Id.repayment_input)).Text);



                int mortage_remaining = (mortage*interest) - repayment;
                int loan_remaining = mortage_remaining / loanterm;





                if (mortage_remaining < 0)
                {
                    textView.SetTextColor(Color.Red);

                    textView.Text = "Please enter a valid values!";

                }
                else if (mortage_remaining == 0)
                {
                    textView.SetTextColor(Color.Black);

                    textView.Text = "You have paid off " + mortage_remaining + "and have nothing left to repay!";

                }
                else if (mortage_remaining > 0)
                {
                    textView.SetTextColor(Color.Green);

                    textView.Text = "You have paid off " + mortage_remaining + "and have" + loan_remaining + "left to repay!";

                }

            };



        }
    }
}
