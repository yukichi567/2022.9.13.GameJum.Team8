using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItem : MonoBehaviour
{
    /// <summary>弾のタグの名前</summary>
    [SerializeField] string _tagName;
    [Header("弾速")]
    [SerializeField] bool _isBulletvelocity;
    [Header("間隔")]
    [SerializeField] bool _isinterval;
    [Header("Hp")]
    [SerializeField] bool _isHp;

    [Header("減らす秒数")]
    [SerializeField] float _time;

    [SerializeField] float _maxSpeed;
    [SerializeField] float _maxbullet;
    PlayerScript _player;
    private void Start()
    {
        _player = GameObject.FindObjectOfType<PlayerScript>();
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == _tagName)
    //    {
    //        //弾速
    //        if (_isBulletvelocity)
    //        {
    //            if (BulletScript._speed <= _maxSpeed)
    //            {
    //                BulletScript._speed *= 1.2f;
    //            }
    //            Destroy(gameObject);
    //        }
    //        //インターバル変更
    //        else if (_isinterval)
    //        {
    //            if (PlayerScript._intarval >= _maxIntarval)
    //            {
    //                PlayerScript._intarval -= _time;
    //            }
    //            Destroy(gameObject);
    //        }
    //        //HP
    //        else if (_isHp)
    //        {
    //            PlayerScript._playerHp++;
    //            Destroy(gameObject);
    //        }
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //弾速
            if (_isBulletvelocity)
            {
                if (BulletScript._speed <= _maxSpeed)
                {
                    BulletScript._speed *= 1.2f;
                }
                Destroy(gameObject);
            }
            //インターバル変更
            else if (_isinterval)
            {
                if (_player._maxBullet <= _maxbullet)
                {
                    _player._maxBullet += 10 ;
                }
                Destroy(gameObject);
            }
            //HP
            else if (_isHp)
            {
                PlayerScript._playerHp++;
                Destroy(gameObject);
            }
        }
    }
}
