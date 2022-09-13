using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItem : MonoBehaviour
{
    /// <summary>�e�̃^�O�̖��O</summary>
    [SerializeField] string _tagName;
    [Header("�e��")]
    [SerializeField] bool _isBulletvelocity;
    [Header("�Ԋu")]
    [SerializeField] bool _isinterval;
    [Header("Hp")]
    [SerializeField] bool _isHp;

    [Header("���炷�b��")]
    [SerializeField] float _time;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //�e��
            if (_isBulletvelocity)
            {
                BulletScript._speed *= 2;
            }
            //�C���^�[�o���ύX
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
