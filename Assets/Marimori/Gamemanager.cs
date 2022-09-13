using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. UI;

public class Gamemanager : MonoBehaviour
{

    [SerializeField]
    [Header("プレイ時間の初期値")]
    private float _GameOverTime = 60f;


    [SerializeField]
    [Header("時間表示")]
     Text _timerlimit;

    [SerializeField]
    [Header("スコア")]
    public float _score;

    [SerializeField]
    [Header("スコア表示")]
    Text _Point;


    public float _time;
    public float _count;
    public float _timelimit = 60;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        _count = _GameOverTime - _time;
        _timerlimit.text = $"{_count.ToString("F1")}";
    }
    
    void AddScore(int _score)
    {

    }
}
