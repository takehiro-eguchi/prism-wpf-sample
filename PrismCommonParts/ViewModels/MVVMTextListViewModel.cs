using Prism.Commands;
using Prism.Mvvm;
using PrismCommonParts.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrismCommonParts.ViewModels
{
    public class MVVMTextListViewModel : BindableBase
    {
        // 子コレクション
        public ObservableCollection<LabelTextBox> Children
        {
            get => children;
            set
            {
                SetProperty(ref children, value);
                if (children != null)
                    children.CollectionChanged += (sender, e) => BuildTextList();
            }
        }
        private ObservableCollection<LabelTextBox> children = new ();

        // ビュー
        internal MVVMTextList View {  get; set; }

        public MVVMTextListViewModel()
        {
           
        }

        internal void SetupTextList()
        {
            // テキストリストの構築
            BuildTextList();

            // イベントハンドラの登録
            Children.CollectionChanged += (sender, e) => BuildTextList();
        }

        private void BuildTextList()
        {
            // StackPanelのテキストを一度クリア
            var contentChildren = View.TextStack.Children;
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
