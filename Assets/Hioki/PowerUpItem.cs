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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //弾速
            if (_isBulletvelocity)
            {
                //弾についてるスクリプトをいじる

            }
            //インターバル変更
            else if(_isinterval)
            {
                //プレイヤーについてるスクリプトをいじる

            }
        }
    }
}
