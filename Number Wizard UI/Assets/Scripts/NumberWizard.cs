using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    // Decalare the instance variables
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessValue;
    int guess; 

    // Use this for initialization
    void Start ()
    {
        
        StartGame();
  
    }

    void StartGame ()
    {
        // Reset Values for each new game.

        GuessGenerator();
        

    }

    void GuessGenerator()
    {
        guess = Random.Range(min, max + 1);
        guessValue.text = guess.ToString();
    }

    void NextGuess()
    {
        GuessGenerator();

    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    
}
