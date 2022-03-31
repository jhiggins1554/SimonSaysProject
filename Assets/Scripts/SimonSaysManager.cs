using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonSaysManager : MonoBehaviour
{
    public List<ColorButton> squares = new List<ColorButton>();
    private List<int> blinks = new List<int>();
    private List<int> inputs = new List<int>();
    private int length = 3;
    
    void Start()
    {
        RoundStart();
    }

    void RoundStart()
    {
        StartCoroutine(Press());
    }

    IEnumerator Press()
    {
        Canvas canvas = FindObjectOfType<Canvas>();
        canvas.GetComponent<GraphicRaycaster>().enabled = false;

        for (int i = 0; i < squares.Count - 1; i++)
        {
            squares[i].button.enabled = false;
        }
        for (int i = 0; i < length; i++)
        {
            int choice = Random.Range(0, squares.Count - 1);
            squares[choice].SelectButton();
            blinks.Add(choice);
            yield return new WaitForSeconds(1f);
            squares[choice].DeselectButton();
            yield return new WaitForSeconds(0.5f);
        }
        for (int i = 0; i < squares.Count - 1; i++)
        {
            squares[i].button.enabled = true;
        }
        canvas.GetComponent<GraphicRaycaster>().enabled = true;
    }

    void Input(int click)
    {
        inputs.Add(click);

        if (blinks[inputs.Count -1] != click)
        {
            inputs.Clear();
        }

        if (blinks.Count == inputs.Count)
        {
            Score.rounds++;
            length++;
            inputs.Clear();
            blinks.Clear();
            StartCoroutine(Press());
        }
    }
}
