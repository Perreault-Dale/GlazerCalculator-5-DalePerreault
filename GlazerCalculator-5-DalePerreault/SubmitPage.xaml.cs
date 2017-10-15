using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GlazerCalculator_5_DalePerreault
{
    public sealed partial class SubmitPage : Page
    {
        public SubmitPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var window = e.Parameter as WindowOrder;
            dateLabel.Text = window.orderDate.ToString();
            widthLabel.Text = window.width.ToString() + " m by ";
            heightLabel.Text = window.height.ToString() + " m";
            woodLabel.Text = "Wood Length: " + window.calcWoodLength(window) + " m";
            glassLabel.Text = "Glass Area: " + window.calcGlassArea(window) + " sq m";
            tintLabel.Text = "Tint: " + window.tint;
            quantLabel.Text = "Quantity: " + window.quantity.ToString();
        }
    }
}
