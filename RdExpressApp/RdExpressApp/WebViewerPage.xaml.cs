5using RdExpressApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RdExpressApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewerPage : ContentPage
    {
        public WebViewerPage()
        {
            InitializeComponent();

            var data = new SerializedObjectManager().RetrieveData();

            ShowWebView(data.ToString());
        }

        void ShowWebView(string branchId)
        {
            view.Source = "https://rodizioexpress.com/menu/" + branchId + "_" + "tablet";
        }
    }
}