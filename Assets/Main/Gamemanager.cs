using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Gamemanager : MonoBehaviour
{
    [SerializeField]
    [Header("�v���C���Ԃ̏����l")]
    private float _GameOverTime = 60f;

    [SerializeField]
    [Header("���ԕ\��")]
    Text _timerlimit;

    
    [Header("�X�R�A")]
    [SerializeField]
    public static int _score;

    
    [Header("�X�R�A�\��")]
    [SerializeField]Text _point;

    [SerializeField]Text _resultText;

    public float _time;
    public float _count;
    public float _timelimit = 60;
    public static bool _isGame;
    float _repopUp;


    /*[Header("�N���A�A�Q�[���I�[�o�[�摜")]
    [SerializeField]
    GameObject _gameOver;*/
    [SerializeField]
    GameObject _gameClear;

    [Header("HP�Q�[�W")]
    [SerializeField]
    Text _HP;
    //[SerializeField]
    //GameObject _HPMax;


    void Start()
    {
        _isGame = true;
    }

    void Update()
    {
        if (_isGame)
        {
            _time += Time.deltaTime;
            _count = _GameOverTime - _time;
            _repopUp += Time.deltaTime;
            _timerlimit.text = $"{_count.ToString("F1")}";
            _point.text = $"{_score.ToString("00000")}";
            _HP.text = $"{PlayerScript._playerHp}";
            //_HP.gameObject.SetActive(true);
            //_HPMax.gameObject.SetActive(true);
            if(_repopUp >= 5f)
            {
                Create._intarval -= 0.1f;
                _repopUp = 0;
            }
            if (_count <= 0 )
            {
                _isGame = false;
                _gameClear.gameObject.SetActive(true);
            }

            if (PlayerScript._playerHp <= 0)
            {
                _isGame = false;
                // _gameOver.gameObject.SetActive(true);
                _gameClear.gameObject.SetActive(true);
            }

        }

        //else if(!_isGame)
        //{
        //    //_resultText.text = $"{_score.ToString("00000")}";
        //    _resultText.DOCounter(0, _score, 1f);
        //}
        
    }

    public static void AddScore(int score)
    {
        _score += score;
        
    }
}
