using PrismCommonParts.ViewModels;
using System.Windows;
using System.Windows.Data;

namespace PrismCommonParts.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // コードによりBinding
            // バインディングソースとしてViewModelのプロパティを設定
            Binding binding = new Binding(
                nameof(MainWindowViewModel.CsOnlyTextCodeBindValue));
            binding.Source = DataContext;
            binding.Mode = BindingMode.TwoWay;  // 双方向
            // UIコンポーネントのバインディングに登録
            CsOnlyBindTextBox.SetBinding(
                LabelTextBox.TextProperty, binding);
        }
    }
}
