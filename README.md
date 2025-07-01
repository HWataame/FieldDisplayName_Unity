# FieldDisplayName
![トップ画像](https://github.com/user-attachments/assets/aecfd96b-3e64-431d-ae40-2d9b40d9936c)

## 概要 / Overview
Unityのフィールドのラベルに任意の文字列を指定する属性を追加します / Add an attribute that specifies any text to the label of the field.

## 使用方法 / Usage
シリアル化されるフィールドに`[FieldDisplayName(表示名)]`属性を付与すると、インスペクター上の表示が変化します / Attaching a `[FieldDisplayName(displayName)]`attribute to a field will change its display in Inspector

![使用方法01](https://github.com/user-attachments/assets/f7cc8f6f-1750-422a-b667-2db3a56ec75c)
```csharp
[SerializeField, FieldDisplayName("Label text")]
private int field;
```

## 導入方法 / English "How to introduction" is below this
1. Gitをインストールする
2. 追加したいプロジェクトを開き、Package Managerを開く
3. 以下の文字列をコピー、またはこのページ上部の「<> Code」からClone URLをコピーする

    https://github.com/HWataame/FieldDisplayName_Unity.git
4. 「Package Manager」ウィンドウの左上の「＋」ボタンをクリックし、「Install package from git URL...」を選択する

    ![導入方法01](https://github.com/user-attachments/assets/60bd8299-0918-4141-9dc8-a60ea5cd2fdd)
5. 入力欄に手順2でコピーしたURLを貼り付け、「Install」ボタンを押す

    ![導入方法02](https://github.com/user-attachments/assets/5c0de8c5-740f-4941-aa6c-922672c0fa76)
6. (必要に応じて)Assembly Definition Assetの管理下のコードで利用する場合は、`HW.FieldDisplayName`をAssembly Definition Referencesに追加する

    ![導入方法03(必要に応じて)](https://github.com/user-attachments/assets/ca897ac5-d5c5-4498-bccb-58152cf716a0)



## How to introduction / 日本語の「導入方法」は上にあります
1. Install Git to your computer.
2. Open Package Manager in the Unity project to which you want to add this feature.
3. Copy the following string, or copy the Clone URL from "<> Code" at the top of this page

    https://github.com/HWataame/FieldDisplayName_Unity.git
4. Click the "+" button in the "Package Manager" window and select "Install package from git URL...".

    ![導入方法01](https://github.com/user-attachments/assets/60bd8299-0918-4141-9dc8-a60ea5cd2fdd)
5. Paste the URL copied in Step 2 into the input field and press the "Install" button.

    ![導入方法02](https://github.com/user-attachments/assets/5c0de8c5-740f-4941-aa6c-922672c0fa76)
6. (If necessary) For use in code under the control of Assembly Definition Asset...

   Add `HW.FieldDisplayName` to "Assembly Definition References" in your Assembly Definition Asset.

    ![導入方法03(必要に応じて)](https://github.com/user-attachments/assets/ca897ac5-d5c5-4498-bccb-58152cf716a0)

## ライセンス / License
MITライセンスです / Using "MIT license"

[LISENCE](/LICENSE)
