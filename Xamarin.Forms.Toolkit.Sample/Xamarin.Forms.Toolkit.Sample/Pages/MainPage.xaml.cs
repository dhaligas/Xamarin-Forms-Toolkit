using Xamarin.Forms.Toolkit.Sample.ViewModel;

namespace Xamarin.Forms.Toolkit.Sample.Pages
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
        }
    }
}
