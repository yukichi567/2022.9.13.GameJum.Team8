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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //弾速
            if (_isBulletvelocity)
            {
                BulletScript._speed *= 2;
            }
            //インターバル変更
            else if(_isinterval)
            {
                BulletGenerator._interval -= _time;
            }
            //HP
            else if(_isHp)
            {
                PlayerScript._playerHp++;
            }
        }
    }
}
