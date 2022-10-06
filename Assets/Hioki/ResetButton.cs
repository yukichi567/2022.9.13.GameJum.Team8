using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{

    public void ResetGame()
    {
        Gamemanager._score = 0;
        PlayerScript._playerHp = 3;
        BulletScript._speed = 2000;
        Create._intarval  = 1f;
        PlayerScript._intarval = 1f;
    }
}