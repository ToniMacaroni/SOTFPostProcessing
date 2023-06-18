using System.Collections;
#if ML
using MelonLoader;
#else
using Endnight.Utilities;
using BepInEx.Unity.IL2CPP.Utils.Collections;
#endif

namespace SOTFPostProcessing.Loader.Common;

public static class UHelpers
{
    public static void InvokeOnMainThread(Action action)
    {
        UnityMainThreadDispatcher.Instance().Enqueue(action);
    }

    public static void RunCoroutine(this IEnumerator coroutine)
    {
#if ML
        MelonCoroutines.Start(coroutine);
#else
        CoroutineHelper.StartCoroutine(coroutine.WrapToIl2Cpp());
#endif
    }
}
