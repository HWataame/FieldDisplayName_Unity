/*
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
[FieldDisplayName]の表示名変更を適用するクラス

FieldDisplayNameDrawer.cs
────────────────────────────────────────
バージョン: 1.0.0
2025 Wataame(HWataame)
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
*/
using UnityEditor;
using UnityEngine;

namespace HW.FieldDisplayName.Editor.Drawer
{
    /// <summary>
    /// [FieldDisplayName]の表示名変更を適用するクラス
    /// </summary>
    [CustomPropertyDrawer(typeof(FieldDisplayNameAttribute))]
    public sealed class FieldDisplayNameDrawer : PropertyDrawer
    {
        /// <summary>
        /// プロパティを描画する
        /// </summary>
        /// <param name="position">プロパティの範囲</param>
        /// <param name="property">プロパティ</param>
        /// <param name="label">ラベル</param>
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (attribute is FieldDisplayNameAttribute name &&
                !string.IsNullOrWhiteSpace(name.DisplayName) &&
                label.text != name.DisplayName)
            {
                // 変更後の表示名と変更前の表示名が異なる場合は差し替える
                label.text = name.DisplayName;
            }
            // プロパティを描画する
            EditorGUI.PropertyField(position, property, label, true);
        }

        /// <summary>
        /// プロパティの高さを取得する
        /// </summary>
        /// <param name="property">プロパティ</param>
        /// <param name="label">ラベル</param>
        /// <returns>プロパティの高さ</returns>
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            // プロパティの高さを取得する
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}
