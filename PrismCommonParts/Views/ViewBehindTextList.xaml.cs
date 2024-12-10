using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            throw new NotImplementedException();
        }

        public ViewBehindTextList()
        {
            InitializeComponent();
        }
    }
}
