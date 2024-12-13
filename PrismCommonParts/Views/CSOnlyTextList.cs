using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PrismCommonParts.Views
{
    [ContentProperty(nameof(Children))]
    public class CSOnlyTextList : UserControl
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
                typeof(CSOnlyTextList),
                new PropertyMetadata(
                    new ObservableCollection<LabelTextBox>(),
                    OnChildrenChanged));
        private static void OnChildrenChanged(
            DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CSOnlyTextList textList)
            {
                // 変更イベントを登録
                if (textList.Children is ObservableCollection<LabelTextBox> textBoxes)
                    textBoxes.CollectionChanged += (sender, e) => textList.BuildTextList();

                // 再構築
                textList.BuildTextList();
            }
        }

        private StackPanel TextStack { get; set; }

        public CSOnlyTextList()
        {
            // パネルを追加
            TextStack = new ()
            {
                Orientation = Orientation.Vertical
            };
            Content = TextStack;

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
