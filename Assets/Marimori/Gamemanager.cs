using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    [SerializeField]
    [Header("�v���C���Ԃ̏����l")]
    private float _GameOverTime = 60f;

    [SerializeField]
    [Header("���ԕ\��")]
    Text _timerlimit;

    [SerializeField]
    [Header("�X�R�A")]
    public float _score;

    [SerializeField]
    [Header("�X�R�A�\��")]
    Text _Point;

    public float _time;
    public float _count;
    public float _timelimit = 60;
    bool _isGame;

    // Start is called before the first frame update
    void Start()
    {
        _isGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isGame)
        {
            _time += Time.deltaTime;
            _count = _GameOverTime - _time;
            _timerlimit.text = $"{_count.ToString("F1")}";
            if (_count <= 0)
            {
                _isGame = false;
            }
        }
        
    }

    void AddScore(int score)
    {
        _score += score;
        _Point.text = $"{_score.ToString("d5")}";
    }
}
