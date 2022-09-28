using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItem : MonoBehaviour
{
    /// <summary>íeÇÃÉ^ÉOÇÃñºëO</summary>
    [SerializeField] string _tagName;
    [Header("íeë¨")]
    [SerializeField] bool _isBulletvelocity;
    [Header("ä‘äu")]
    [SerializeField] bool _isinterval;
    [Header("Hp")]
    [SerializeField] bool _isHp;

    [Header("å∏ÇÁÇ∑ïbêî")]
    [SerializeField] float _time;

    [SerializeField] float _maxSpeed;
    [SerializeField] float _maxIntarval;
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
                Destroy(gameObject);
            }
            //ÉCÉìÉ^Å[ÉoÉãïœçX
            else if(_isinterval)
            {
                if (PlayerScript._intarval >= 0.1f)
                {
                    PlayerScript._intarval -= _time;
                }
                Destroy(gameObject);
            }
            //HP
            else if(_isHp)
            {
                PlayerScript._playerHp++;
                Destroy(gameObject);
            }
        }
    }
}
