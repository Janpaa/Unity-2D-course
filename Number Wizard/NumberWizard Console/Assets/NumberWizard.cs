using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min;
    int max;
    int guess;
    int steps;
    // Start is called before the first frame update
    void Start(){
        StartGame();
    }

    void StartGame()
    {
        steps = 0;
        min = 1;
        max = 1000;
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number between " + min + " and " + max);
        max = max + 1;
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct");
        nextGuess();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I found your number "+guess+" in: " + steps+" steps!");
            StartGame();
        }
    }
    void nextGuess()
    {
        guess = Mathf.RoundToInt((min + max) / 2);
        Debug.Log("Is it higher or lower than: " + guess);
        steps++;
    }
}
