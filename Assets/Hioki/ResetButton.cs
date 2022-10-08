using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{

    public void ResetGame()
    {
        Gamemanager._score = 0;
        PlayerScript._playerHp = 3;
        BulletScript._speed = 50;
        Create._intarval  = 1.5f;
        PlayerScript._intarval = 0.1f;
    }
}