using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public enum GameState { Preload, Menu };
public class StateManager : MonoBehaviour
{

    public GameState gameState;

    private void Awake()
    {
        SetGameSate(GameState.Menu);
    }

    public void SetGameSate(GameState newState)
    {
        if (newState == GameState.Preload)
        {

        }
        else if (newState == GameState.Menu)
        {
            SceneManager.LoadSceneAsync("Menu");
        }
   
        gameState = newState;
    }





}
