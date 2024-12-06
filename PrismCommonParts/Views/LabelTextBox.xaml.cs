using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrismCommonParts.Views
{
    /// <summary>
    /// LabelTextBox.xaml の相互作用ロジック
    /// </summary>
    public partial class LabelTextBox : UserControl
    {
        /// <summary> ラベルプロパティ </summary>
        public string Label
        {
            get => GetValue(LabelProperty) as string;
            set => SetValue(LabelProperty, value);
        }
        public static readonly DependencyProperty LabelProperty
            = DependencyProperty.Register(
                nameof(Label),
                typeof(string),
                typeof(LabelTextBox),
                new PropertyMetadata(null, OnLabelChanged));
        private static void OnLabelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is LabelTextBox labelTextBox)
            {
                // ラベルに反映
                string label = labelTextBox.Label;
                labelTextBox.TextLabel.Content = label;

                // ラベルの内容が空の場合はラベルの領域を閉じておく
                labelTextBox.LabelStack.Visibility = !string.IsNullOrEmpty(label) ?
                    Visibility.Visible : Visibility.Collapsed;
            }
        }

        /// <summary> 必須フラグプロパティ </summary>
        public bool IsRequred
        {
            get => (bool)GetValue(IsRequredProperty);
            set => SetValue(IsRequredProperty, value);
        }
        public static readonly DependencyProperty IsRequredProperty
            = DependencyProperty.Register(
                nameof(IsRequred),
                typeof(bool),
                typeof(LabelTextBox),
                new PropertyMetadata(false, OnIsRequredChanged));
        private static void OnIsRequredChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is LabelTextBox labelTextBox)
            {
                // 必須フラグの値によって必須マークの表示・非表示を切り替える
                labelTextBox.RequiredMark.Visibility = labelTextBox.IsRequred ?
                    Visibility.Visible : Visibility.Hidden;
            }
        }

        /// <summary> テキストプロパティ </summary>
        public string Text
        {
            get => GetValue(TextProperty) as string;
            set => SetValue(TextProperty, value);
        }
        public static readonly DependencyProperty TextProperty
            = DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(LabelTextBox),
                new PropertyMetadata(null));

        /// <summary> 読み取り専用プロパティ </summary>
        public bool IsReadOnly
        {
            get => (bool)GetValue(IsReadOnlyProperty);
            set => SetValue(IsReadOnlyProperty, value);
        }
        public static readonly DependencyProperty IsReadOnlyProperty
            = DependencyProperty.Register(
                nameof(IsReadOnly),
                typeof(bool),
                typeof(LabelTextBox),
                new PropertyMetadata(false, OnIsReadOnlyChanged));
        private static void OnIsReadOnlyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is LabelTextBox labelTextBox)
            {
                // 読み取り専用を反映
                labelTextBox.TextContent.IsReadOnly = labelTextBox.IsReadOnly;
            }
        }

        public LabelTextBox()
        {
            InitializeComponent();
        }
    }
}
