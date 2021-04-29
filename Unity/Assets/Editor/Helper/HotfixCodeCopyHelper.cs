﻿//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2021年4月26日 18:21:50
//------------------------------------------------------------

using System.IO;
using UnityEditor;

namespace ET
{
    [InitializeOnLoad]
    public static class HotfixCodeCopyHelper
    {
        private const string ScriptAssembliesDir = "Library/ScriptAssemblies";
        private const string CodeDir = "Assets/Res/Code/";
        private const string HotfixDll = "Unity.Hotfix.dll";
        private const string HotfixPdb = "Unity.Hotfix.pdb";
        private const string HotfixViewDll = "Unity.HotfixView.dll";
        private const string HotfixViewPdb = "Unity.HotfixView.pdb";

        static HotfixCodeCopyHelper()
        {
            File.Copy(Path.Combine(ScriptAssembliesDir, HotfixDll), Path.Combine(CodeDir, "Hotfix.dll.bytes"), true);
            File.Copy(Path.Combine(ScriptAssembliesDir, HotfixPdb), Path.Combine(CodeDir, "Hotfix.pdb.bytes"), true);
            // File.Copy(Path.Combine(ScriptAssembliesDir, HotfixViewDll), Path.Combine(CodeDir, "HotfixView.dll.bytes"), true);
            // File.Copy(Path.Combine(ScriptAssembliesDir, HotfixViewPdb), Path.Combine(CodeDir, "HotfixView.pdb.bytes"), true);
            Log.Info($"复制Hotfix dlls到Res/Code完成");
            AssetDatabase.Refresh();
        }
    }
}