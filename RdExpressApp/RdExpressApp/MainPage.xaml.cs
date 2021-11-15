using RdExpressApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RdExpressApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SaveBranchId(branchId.Text);
        }
        void SaveBranchId(string id)
        {
            if(id != null && id.Length == 5)
            {
                new SerializedObjectManager().SaveData("rd" + id);

                Application.Current.MainPage = new WebViewerPage();

                return;
            }

            DisplayAlert("Error", "The id you entered is incorrect", "Close");            
        }
    }
}
