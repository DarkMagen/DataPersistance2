using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameScore : MonoBehaviour
{
    
    public Text text;
    public Text TopScoreText;
    // Start is called before the first frame update
    void Start()
    {
        TopScoreText = text.GetComponent<Text>();
        if (MenuUI.Instance.PlayerName != null)
        {
            text.text = MenuUI.Instance.PlayerName; 
        }
        else
        {
            text.text = "Still not fixed";
        }
    }

}
