using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text roundsClear;
    public static float rounds = 0;

    void Update()
    {
        roundsClear.text = "" + rounds;
    }
}
