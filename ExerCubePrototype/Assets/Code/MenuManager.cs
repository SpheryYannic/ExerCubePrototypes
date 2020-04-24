using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MenuState { ReadyUp, Start, GameModeSelection, QuickGameSelection, WorkoutSelection, CompetitionSelection, Back };



public class MenuManager : MonoBehaviour
{

    public MenuState state;
    public MenuState lastState;

    public GameObject readyUpMode;
    public GameObject startModeSelection;
    public GameObject gameModeSelection;
    public GameObject quickGameSelection;
    public GameObject workoutSelection;
    public GameObject competitionSelection;

    public List<GameObject> allMenus = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        ChangeMenu(MenuState.Start);
    }

    // Update is called once per frame
    void Update()
    {
        //Wenn nicht alle Trackers senden, gehe in readyup Mode


    }

    public void ChangeMenu(MenuState newState)
    {

        foreach (var item in allMenus)
        {
            item.gameObject.SetActive(false);
        }

        if (newState == MenuState.Back)
        {
            newState = lastState;
        }

        if(newState == MenuState.ReadyUp)
        {
            readyUpMode.SetActive(true);

            foreach (var item in readyUpMode.GetComponentsInChildren<ButtonTarget>())
            {
                item.gameObject.SetActive(true);
                item.Reset();
            }
        }
        else if(newState == MenuState.Start)
        {
            startModeSelection.SetActive(true);

            foreach (var item in startModeSelection.GetComponentsInChildren<ButtonTarget>())
            {
                item.gameObject.SetActive(true);
                item.Reset();
            }
        }
        else if (newState == MenuState.GameModeSelection)
        {
            gameModeSelection.SetActive(true);

            foreach (var item in gameModeSelection.GetComponentsInChildren<ButtonTarget>())
            {
                item.gameObject.SetActive(true);
                item.Reset();

            }
        }
        else if (newState == MenuState.QuickGameSelection)
        {
            quickGameSelection.SetActive(true);

            foreach (var item in quickGameSelection.GetComponentsInChildren<ButtonTarget>())
            {
                item.gameObject.SetActive(true);
                item.Reset();

            }
        }
        else if (newState == MenuState.WorkoutSelection)
        {
            workoutSelection.SetActive(true);

            foreach (var item in workoutSelection.GetComponentsInChildren<ButtonTarget>())
            {
                item.gameObject.SetActive(true);
                item.Reset();

            }
        }
        else if (newState == MenuState.CompetitionSelection)
        {
            competitionSelection.SetActive(true);

            foreach (var item in competitionSelection.GetComponentsInChildren<ButtonTarget>())
            {
                item.gameObject.SetActive(true);
                item.Reset();

            }
        }

        lastState = state;
        state = newState;

    }


    public IEnumerator Wait2SecToChangeState(MenuState newState)
    {
        Debug.Log("Entered Enumerator");
        yield return new WaitForSeconds(2);

        ChangeMenu(newState);

    }

}
