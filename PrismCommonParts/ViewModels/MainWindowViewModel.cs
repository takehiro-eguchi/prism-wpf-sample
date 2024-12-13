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

        public string ViewBehindLabelValue
        {
            get => viewBehindLabelValue;
            set => SetProperty(ref viewBehindLabelValue, value);
        }
        private string viewBehindLabelValue = "2番目のラベル";

        public string ViewBehindTextValue
        {
            get => viewBehindTextValue;
            set => SetProperty(ref viewBehindTextValue, value);
        }
        private string viewBehindTextValue = "2番目のテキスト";

        public MainWindowViewModel()
        {

        }
    }
}
