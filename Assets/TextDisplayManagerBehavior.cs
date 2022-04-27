using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDisplayManagerBehavior : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextBoard;

    private String[] sentence;

    private int wordIndex;

    private int sentenceIndex;
    // Start is called before the first frame update
    public void UserTyped(String userInput)
    {
        if (TextBoard)
        {
            String currWord = sentence[sentenceIndex];
            String expectedInput = currWord[wordIndex].ToString();
            Debug.Log("pde ${0}");
            // if (userInput.Equals())
            TextBoard.text += userInput;
        }
    }
    void Start()
    {
        TextBoard.color = Color.red;
        this.sentence = new string[] {"hello", "world"};
        this.wordIndex = 0;
        this.sentenceIndex = 0;
    }

    void UpdateTextBoardText(String text, Color color)
    {
        TextBoard.text = text;
        TextBoard.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
