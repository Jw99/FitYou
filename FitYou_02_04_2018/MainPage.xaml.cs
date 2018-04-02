using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FitYou_02_04_2018
{
	public partial class MainPage : ContentPage
	{
        StackLayout mainLayout = new StackLayout();
        FeedView feedV = new FeedView();
        MapView mapV = new MapView();
        PostView postV = new PostView();
        AZView azV = new AZView();
        ProfileView profileV = new ProfileView();

        public MainPage()
        {
            InitializeComponent();
            mainLayout = this.FindByName<StackLayout>("DynamicPageView");
        }

        private void Feed_Clicked(object sender, EventArgs e)
        {
            mainLayout.Children.Clear();
            mainLayout.Children.Add(feedV);
        }

        private void Map_Clicked(object sender, EventArgs e)
        {
            mainLayout.Children.Clear();
            mainLayout.Children.Add(mapV);
        }

        private void Post_Clicked(object sender, EventArgs e)
        {
            mainLayout.Children.Clear();
            mainLayout.Children.Add(postV);
        }

        private void AZ_Clicked(object sender, EventArgs e)
        {
            mainLayout.Children.Clear();
            mainLayout.Children.Add(azV);
        }

        private void Profil_Clicked(object sender, EventArgs e)
        {
            mainLayout.Children.Clear();
            mainLayout.Children.Add(profileV);
        }
    }
}
