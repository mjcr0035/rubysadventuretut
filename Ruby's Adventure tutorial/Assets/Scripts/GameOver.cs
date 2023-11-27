using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameEndMessage;
    public string gameEnd;

    TextMeshProUGUI gameEndText;

    public RubyController rubyController;
        
    // Start is called before the first frame update
    void Start()
    {
        gameEndMessage.SetActive(false);
        gameEndText = gameEndMessage.GetComponent<TextMeshProUGUI>();        
    }

    // Update is called once per frame
    void Update()
    {
        rubyController = rubyController.GetComponent<RubyController>();

        if (rubyController.currentHealth < -1)
        {
            gameEndMessage.SetActive(true);
            gameEndText.text = "You lost! Press R to Restart!";

        }

        if (rubyController.score > 3)
        {
            gameEndMessage.SetActive(true);
            gameEndText.text = "You Win! Game created by Group 15!";

        }
    }
}
