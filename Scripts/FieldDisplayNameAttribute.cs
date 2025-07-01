/*
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
フィールドの表示名を置き換えることを示す属性

FieldDisplayNameAttribute.cs
────────────────────────────────────────
バージョン: 1.0.0
2025 Wataame(HWataame)
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
*/
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HW.FieldDisplayName
{
    /// <summary>
    /// フィールドの表示名を置き換えることを示す属性
    /// </summary>
    [Conditional("UNITY_EDITOR")]
    public sealed class FieldDisplayNameAttribute : PropertyAttribute
    {
        /// <summary>
        /// 表示名
        /// </summary>
        private readonly string displayName;

        /// <summary>
        /// 表示名
        /// </summary>
        public string DisplayName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => displayName;
        }


        /// <summary>
        /// フィールドの表示名を置き換える
        /// </summary>
        /// <param name="displayName">フィールドの表示名</param>
        public FieldDisplayNameAttribute(string displayName) : base(applyToCollection: true)
        {
            // 表示名の文字列を設定する
            this.displayName = displayName;
            // 同じorder値以外のすべての属性よりも先に実行させる
            order = int.MinValue;
        }
    }
}
