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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //íeë¨
            if (_isBulletvelocity)
            {
                BulletScript._speed *= 2;
            }
            //ÉCÉìÉ^Å[ÉoÉãïœçX
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
