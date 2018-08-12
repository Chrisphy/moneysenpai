using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace moneysenpai
{
    [Activity(Label = "moneysenpai", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btnExpense = FindViewById<Button>(Resource.Id.button_expense);

            Button btnSavings = FindViewById<Button>(Resource.Id.button_saving);

            Button btnInvestments = FindViewById<Button>(Resource.Id.button_investment);

            Button btnLoan = FindViewById<Button>(Resource.Id.button_loan);


            btnExpense.Click += delegate {


                startActivity(typeof(expense_calculator));


            };

            btnSavings.Click += delegate {


                startActivity(typeof(saving_tips));



            };


            btnInvestments.Click += delegate {


                startActivity(typeof(investment_tips));



            };


            btnLoan.Click += delegate {


                startActivity(typeof(loan_calculator));



            };


        }

        public void startActivity(Type myActivity)
        {
            var intent = new Intent(this, myActivity);
            StartActivity(intent);        }


    }
}

