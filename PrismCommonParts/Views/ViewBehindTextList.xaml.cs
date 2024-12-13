using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PrismCommonParts.Views
{
    /// <summary>
    /// ViewBehindTextList.xaml の相互作用ロジック
    /// </summary>
    [ContentProperty(nameof(Children))]
    public partial class ViewBehindTextList : UserControl
    {
        /// <summary> 子要素 </summary>
        public ObservableCollection<LabelTextBox> Children
        {
            get => GetValue(ChildrenProperty) as ObservableCollection<LabelTextBox>;
            set => SetValue(ChildrenProperty, value);
        }
        public static readonly DependencyProperty ChildrenProperty
            = DependencyProperty.Register(
                nameof(Children),
                typeof(ObservableCollection<LabelTextBox>),
                typeof(ViewBehindTextList),
                new PropertyMetadata(
                    new ObservableCollection<LabelTextBox>(),
                    OnChildrenChanged));
        private static void OnChildrenChanged(
            DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ViewBehindTextList textList)
            {
                // 変更イベントを登録
                if (textList.Children is ObservableCollection<LabelTextBox> textBoxes)
                    textBoxes.CollectionChanged += (sender, e) => textList.BuildTextList();

                // 再構築
                textList.BuildTextList();
            }
        }

        public ViewBehindTextList()
        {
            InitializeComponent();

            // イベントを登録
            Children.CollectionChanged += (sender, e) => BuildTextList();
        }

        private void BuildTextList()
        {
            // StackPanelのテキストを一度クリア
            var contentChildren = TextStack.Children;
            contentChildren.Clear();

            // 追加されたテキストを追加
            if (Children != null)
            {
                foreach (var childText in Children)
                {
                    contentChildren.Add(childText);
                }
            }
        }
    }
}
