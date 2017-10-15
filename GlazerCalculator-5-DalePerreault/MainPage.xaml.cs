using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalculator_5_DalePerreault
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        const double MAX_WIDTH  = 5.0;
        const double MIN_WIDTH  = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;

        public MainPage()
        {
            this.InitializeComponent();
        }

        public void widthTextBox_textChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            double width = 0.0;
            if (double.TryParse(widthTextBox.Text, out width))
            {
                if (width < MIN_WIDTH || width > MAX_WIDTH)
                {
                    widthTextBox.Text = MIN_WIDTH + " - " + MAX_WIDTH;
                    widthTextBox.Focus(Windows.UI.Xaml.FocusState.Programmatic);
                }
            }
            else
                {
                    widthTextBox.Text = MIN_WIDTH.ToString();
                    widthTextBox.Focus(Windows.UI.Xaml.FocusState.Programmatic);
                }
        }

        private void heightTextBox_textChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            double height = 0.0;
            if (double.TryParse(heightTextBox.Text, out height))
            {
                if (height < MIN_HEIGHT || height > MAX_HEIGHT)
                {
                    heightTextBox.Text = MIN_HEIGHT + " - " + MAX_HEIGHT;
                    heightTextBox.Focus(Windows.UI.Xaml.FocusState.Programmatic);
                }
            }
            else
            {
                heightTextBox.Text = MIN_HEIGHT.ToString();
                heightTextBox.Focus(Windows.UI.Xaml.FocusState.Programmatic);
            }
        }

        private void submitButton_click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Create window object
            double width = double.Parse(widthTextBox.Text);
            double height = double.Parse(heightTextBox.Text);
            string tint = ((ComboBoxItem)tintComboBox.SelectedItem).Content.ToString();
            int quantity = (int)quantitySlider.Value;
            WindowOrder window = new WindowOrder(width, height, tint, quantity);

            // Open the Submit page
            this.Frame.Navigate(typeof(SubmitPage), window);
        }
    }
}
