using UnityEngine;
using UnityEditor;

public class ObjectFieldTest : EditorWindow
{
    public Texture texture;

    [MenuItem("Window/ObjectFieldTest")]
    static void Open()
    {
        EditorWindow.GetWindow<ObjectFieldTest>("ObjectFieldTest"); // ウィンドウのタイトル
    }

	void OnGUI()
    {
        texture = EditorGUILayout.ObjectField(texture, typeof(Texture), true) as Texture;
    }
}
