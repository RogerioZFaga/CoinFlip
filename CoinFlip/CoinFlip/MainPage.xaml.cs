namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            int coin = new Random().Next(2);
            if (coin == 0) {
                Image.Source = "coroa.png
            }
        }
    }

}
