
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
    [Activity(Label = "investment_tips")]
    public class investment_tips : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.investment_tips);

            WebView webview_invest = FindViewById<WebView>(Resource.Id.webView_invest);

            webview_invest.SetWebViewClient(new WebViewClient());

            webview_invest.Settings.JavaScriptEnabled = true;


            string htmltext_invest = "<html>" +
               "<head>" +
               "<title> My app </title>" +
               "</head>" +
               "<body>" +
               "<h2 style = \"color:#03A9F4\"> Some helpful tips for Investing. These should help you meet your goals!</ h2 >" +
               "\t\t<ol>" +
               "<li> Keep a record of stocks you are interested in. </li>" +
               "<li> Invest in an ETF if you have no idea what to invest in. </li>" +
               "<li> A High interest account is good for awhile but it eventually is worse than investing elsewhere. </li>" +
               "<li> Real estate can be a good investment. </li>" +
               "<li> Try microinvestment options such as Acorns. </li>" +
               "<li> Maximise your super so you can use the tax benefits. </li>" +
               "<li> Invest in courses/books that will teach you skills that could grow your wealth. </li>" +
               "<li> Make an effort to learn the fundamentals of how money and therefore value is generated. </li>" +
               "<li> Do not just rely on your investments to run themselves. </li>" +
               "<li> Make sure that no one is ever in full control of your money and investments. </li>" +
               "<li> Pay your taxes on investments, it is not worth the trouble dodging them. </li>" +
               "<li> Your money should always be working for you and not the other way around, if you need to work a lot to maintain the returns the process needs to be more efficient. </li>" +
               "<li> Online businesses have been shown to be a good way to invest money in an actual product. </li>" +
               "<li> Let the power of compound interest work for you. Don't aim for returns of 60-80% a year, a mere 5-10% is more than enough to be comfortably rich. </li>" +
               "\t\t<ol>" +
               "</body>" +
               "</html>";



            webview_invest.LoadData(htmltext_invest, "text/html", null);








            // Create your application here
        }
    }
}
