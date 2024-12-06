using Prism.Mvvm;

namespace PrismCommonParts.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private string _title = "Prism Application";

        public string LabelText
        {
            get => labelText;
            set => SetProperty(ref labelText, value);
        }
        private string labelText;

        public string ContentText
        {
            get => contentText;
            set => SetProperty(ref contentText, value);
        }
        private string contentText;

        public MainWindowViewModel()
        {

        }
    }
}
