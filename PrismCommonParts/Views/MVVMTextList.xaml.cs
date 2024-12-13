using PrismCommonParts.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PrismCommonParts.Views
{
    /// <summary>
    /// Interaction logic for MVVMTextList
    /// </summary>
    [ContentProperty(nameof(Children))]
    public partial class MVVMTextList : UserControl
    {
        // ビューモデル
        private MVVMTextListViewModel ViewModel => DataContext as MVVMTextListViewModel;

        // 子コレクション
        public ObservableCollection<LabelTextBox> Children
        {
            get => ViewModel.Children;
            set => ViewModel.Children = value;
        }

        public MVVMTextList()
        {
            InitializeComponent();

            // ビュー登録
            ViewModel.View = this;

            // セットアップ
            ViewModel.SetupTextList();
        }
    }
}
