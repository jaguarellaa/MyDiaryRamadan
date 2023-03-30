using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class DataHandler : MonoBehaviour
{   

    public PlayerDataModel Player;
    public SaveButton SB;



    void Start()
    {
        Player = new PlayerDataModel().Load();
        SB.CanvasStart();
    }

    
    public static void ClearAllData()
    {
        string[] files = System.IO.Directory.GetFiles(Application.persistentDataPath, "*.dat");
        for (int i = 0; i < files.Length; i++)
        {
            System.IO.File.Delete(files[i]);
        }

        PlayerPrefs.DeleteAll();
    }
    public void E_ClearData()
    {
        ClearAllData();

    }


}



#if UNITY_EDITOR
[CustomEditor(typeof(DataHandler))]
public class DataHandlerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Delete Data"))
        {
            ((DataHandler)target).E_ClearData();
        }
    }
}

#endif