using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    // Create instance for data sharing
    public static DataManager Instance;
    
    public string PlayerName;
    // Start is called before the first frame update
    //public Text text;
    //public Text TopScoreText;
    // Start is called before the first frame update
    //private string inputField;
    public InputField TopScoreText;
    public string getTopScoreText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //userNameInputText = canvas.transform.Find("InputField/Text").GetComponent<Text>();
        //userNameInputText = Text.GetComponent(Text)();
        //Stuck on getting name, maybe on enter down?
        //TopScoreText = text.GetComponent<Text>();
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

    public void displayPlayername()
    {
       TopScoreText.text = Instance.PlayerName + ", your score to beat is: ";
    }


}
