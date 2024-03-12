using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    // Create instance for data sharing
    public static MenuUI Instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Make sure there is only one instance
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //Load up new game
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // exit game / also allow editor to exit
    public void Exit()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif  
    }
}
