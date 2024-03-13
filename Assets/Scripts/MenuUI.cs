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
    public string playerName;
    public InputField NameInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SavePlayername()
    {
        playerName = NameInput.text;
        //string userNameInputText = NameInput.text.ToString();
        Debug.Log(playerName);
        DataManager.Instance.PlayerName = playerName;
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
