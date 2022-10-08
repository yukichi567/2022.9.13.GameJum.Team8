using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpItem : MonoBehaviour
{
    /// <summary>íeÇÃÉ^ÉOÇÃñºëO</summary>
    [SerializeField] string _tagName;
    [SerializeField] GameObject _heartPrefab;
    GameObject _heartPanel;
    Gamemanager _gamemanager;
    [Header("íeë¨")]
    [SerializeField] bool _isBulletvelocity;
    [Header("ä‘äu")]
    [SerializeField] bool _isinterval;
    [Header("Hp")]
    [SerializeField] bool _isHp;

    [Header("å∏ÇÁÇ∑ïbêî")]
    [SerializeField] float _time;

    [SerializeField] float _maxSpeed;
    [SerializeField] float _maxbullet;
    [SerializeField] int _maxHp;
    [SerializeField] int _score;
    PlayerScript _player;
    private void Start()
    {
        _player = GameObject.FindObjectOfType<PlayerScript>();
        _gamemanager = GameObject.FindObjectOfType<Gamemanager>();
        _heartPanel = GameObject.Find("HeartPanel");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //íeë¨
            if (_isBulletvelocity)
            {
                if (BulletScript._speed <= _maxSpeed)
                {
                    BulletScript._speed *= 1.2f;
                }
                else
                {
                    Gamemanager.AddScore(_score);
                }
                Destroy(gameObject);
            }
            //ÉCÉìÉ^Å[ÉoÉãïœçX
            else if (_isinterval)
            {
                if (_player._maxBullet <= _maxbullet)
                {
                    _player._maxBullet += 10 ;
                }
                else
                {
                    Gamemanager.AddScore(_score);
                }
                Destroy(gameObject);
            }
            //HP
            else if (_isHp)
            {
                if (PlayerScript._playerHp <= _maxHp)
                {
                    PlayerScript._playerHp++; 
                }
                else
                {
                    Gamemanager.AddScore(_score);
                }
                Destroy(gameObject);
            }
        }
    }
}
