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
    public static float _score;

    
    [Header("�X�R�A�\��")]
    [SerializeField]public static Text _point;

    [SerializeField]Text _resultText;

    public float _time;
    public float _count;
    public float _timelimit = 60;
    bool _isGame;


    [Header("�N���A�A�Q�[���I�[�o�[�摜")]
    [SerializeField]
    GameObject _gameOver;
    [SerializeField]
    GameObject _gameClear;

    [Header("HP�Q�[�W")]
    [SerializeField]
    GameObject _HP;
    [SerializeField]
    GameObject _HPMax;


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
            _point.text = $"{_score.ToString("00000")}";
            _HP.gameObject.SetActive(true);
            _HPMax.gameObject.SetActive(true);

            if (_count <= 0 )
            {
                _isGame = false;
                _gameClear.gameObject.SetActive(true);
            }

            if (PlayerScript._playerHp <= 0)
            {
                _isGame = false;
                _gameOver.gameObject.SetActive(true);
            }

        }

        else if(_isGame == false)
        {
            _resultText.text = $"{_score.ToString("00000")}";
        }
        
    }

    public static void AddScore(int score)
    {
        _score += score;
        _point.text = $"{_score.ToString("00000")}";
    }
}
