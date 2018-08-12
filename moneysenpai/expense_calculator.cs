
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
    [Activity(Label = "expense_calculator")]
    public class expense_calculator : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.expense_calculator);

            TextView textView = FindViewById<TextView>(Resource.Id.textview_expenses);






            Button calc = FindViewById<Button>(Resource.Id.calculate_button);


            calc.Click += delegate {

                int income = Convert.ToInt32((FindViewById<EditText>(Resource.Id.income_input)).Text);

                int food = Convert.ToInt32((FindViewById<EditText>(Resource.Id.food_input)).Text);

                int utility = Convert.ToInt32((FindViewById<EditText>(Resource.Id.utility_input)).Text);

                int entertainment = Convert.ToInt32((FindViewById<EditText>(Resource.Id.entertainment_input)).Text);

                int other = Convert.ToInt32((FindViewById<EditText>(Resource.Id.other_input)).Text);


                
                int expenses = (income - food - utility - entertainment - other);                 

                if(expenses < 0){
                    textView.SetTextColor(Color.Red);

                    textView.Text = "Your expenses are more than your income! It is " + expenses;
                
                }
                else if (expenses == 0){
                    textView.SetTextColor(Color.Black);

                    textView.Text = "You broke-even! It is " + expenses;

                }
                else if (expenses > 0)
                {
                    textView.SetTextColor(Color.Green);

                    textView.Text = "Your income are more than your expenses! It is " + expenses;

                }







            };



            // Create your application here
        }
    }
}
