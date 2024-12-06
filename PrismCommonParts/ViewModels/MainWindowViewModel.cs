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
        private string labelText = "（初期値）";

        public string ContentText
        {
            get => contentText;
            set => SetProperty(ref contentText, value);
        }
        private string contentText;

        public bool IsRequired
        {
            get => isRequired;
            set => SetProperty(ref isRequired, value);
        }
        private bool isRequired;

        public MainWindowViewModel()
        {

        }
    }
}
