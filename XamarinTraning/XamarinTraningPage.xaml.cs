using Xamarin.Forms;
using XamarinTraning.Model;

namespace XamarinTraning
{
    public partial class XamarinTraningPage : ContentPage
    {
        TestModel model;

        public XamarinTraningPage()
        {
            InitializeComponent();

            model = new TestModel();

            lblTest.BindingContext = model;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            model.Message = "押されたよ！";
        }
    }
}
