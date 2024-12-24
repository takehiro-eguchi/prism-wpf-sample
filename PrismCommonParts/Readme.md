# 概要
このプロジェクトは`Prism`及び`WPF`にて共通部品を作成する際に
発生する問題を再現するためのものです。

# 画面説明

|コンポーネント|説明|
|---|---|
|LabelTextBox|ラベル付きのテキストボックスとなります。<br>非常にシンプルな共通部品となります。|
|MVVMTextList|`LabelTextBox`を組み込んで一覧化する共通部品となります。<br>`.xaml`、`.xaml.cs`、`~ViewModel.cs`で構成されています。|
|ViewBehindTextList|`MVVMTextList`から`~ViewModel.cs`を除去した共通部品となります。|
|CSOnlyTextList|`ViewBehindTextList`から`.xaml`すら除去してC#のみで作成した共通部品となります。|
|MainWindow|上で登場する共通部品を配置したウィンドウです。|

# 起動方法

`VisualStudio2022`、`.NET8`がインストールされている状態で、
`PrismCommonParts`を選択し、`デバッグを開始`してください。