using System.Data;

namespace MauiAppMaths
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
         if(!String.IsNullOrEmpty(exprEntry.Text))
            {
                DataTable dt = new DataTable();
                var r = dt.Compute(exprEntry.Text, "");
                exprEntry.Text = $"Votre resultat est {r}";
            }
        
        }
    }

}
