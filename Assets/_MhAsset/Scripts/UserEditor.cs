

#if(UNITY_EDITOR)
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class UserEditor : MonoBehaviour
{
    public static void OpenScene(string sceneName)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/_MhAsset/Scenes/" + sceneName + ".unity");
        }
    }

    [MenuItem("[ Open Scene ]/1_Mh_Lobby")]
    public static void OpenScene_Lobby()
    {
        OpenScene("Mh_Main Menu");
    }


    [MenuItem("[ Open Scene ]/2_Mh_GamePlay")]
    public static void OpenScene_ShopVsInventory()
    {
        OpenScene("Mh_Main");
    }

    

}

#endif
