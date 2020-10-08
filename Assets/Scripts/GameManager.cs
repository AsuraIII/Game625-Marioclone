using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    //Game score
    private int score = 0;

    //Player Health
    private int playerHealth = 100;

    private void Awake()
    {
        _instance = this;
    }

    public int Score
    {
        get { return score; }
        set { score = value; }
    }
    public int PlayerHealth
    {
        get { return playerHealth; }
        set { playerHealth = value; }
    }




}
