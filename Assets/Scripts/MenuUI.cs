using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    // Create instance for data sharing
    public static MenuUI Instance;
    public string PlayerName;
    public string userNameInputText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //userNameInputText = canvas.transform.Find("InputField/Text").GetComponent<Text>();
        //userNameInputText = Text.GetComponent(Text)();
        //Stuck on getting name, maybe on enter down?
    }

    //Make sure there is only one instance
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //Load up new game
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void SavePlayername(string userNameInputText)
    {
        MenuUI.Instance.PlayerName = userNameInputText;
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
