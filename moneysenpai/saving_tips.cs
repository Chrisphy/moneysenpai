using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace moneysenpai
{
    [Activity(Label = "saving_tips")]
    public class saving_tips : Activity
    {
        WebView webview;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.saving_tips);

            webview = FindViewById<WebView>(Resource.Id.webView_savings);

            webview.SetWebViewClient(new WebViewClient());

            webview.Settings.JavaScriptEnabled = true;



            string htmltext = "<html>" +
                "<head>" +
                "<title> My app </title>" +
                "</head>" +
                "<body>" +
                "<h2 style = \"color:#03A9F4\"> Some helpful tips for saving. These should help you meet your goals!</ h2 >" +
                "\t\t<ol>" +
                "<li> Make an Emergency Fund with preferably around 2-3 months living expenses. </li>" +
                "<li> Make a weekly budget to help you keep track of how much you spend. </li>" +
                "<li> Use an app to track your spending to keep you on your toes. </li>" +
                "<li> Make short term saving goals to aim for. </li>" +
                "<li> Reward yourself when you meet your saving goals. </li>" +
                "<li> Take full advantage of some HISA (High interest saving accounts) accounts. </li>" +
                "<li> Round up your loose change into your bank account, some banks provide this such as UBank. </li>" +
                "<li> Try to cut down on your weekly expenses as far as possible. </li>" +
                "<li> Get rid of as much debt as possible. </li>" +
                "<li> Unsubscribe from monthly purchases that aren't needed such as Netflix. </li>" +
                "<li> Pay off all your credit cards on time. </li>" +
                "<li> Never let someone else manage your money for you. </li>" +
                "<li> Have a longer term goal to aim for such as a house. </li>" +
                "<li> Aim to eat at home and cook over eating out. </li>" +
                "<li> Splurge on necessities not needs. </li>" +
                "<li> Organise and do research on necessary bills like electricty and water there may be better rates. </li>" +
                "\t\t<ol>" +
                "</body>" +
                "</html>";



            webview.LoadData(htmltext, "text/html", null);

            // Create your application here
        }
    }
}
