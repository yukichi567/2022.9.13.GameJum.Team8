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

    [SerializeField] float _maxSpeed;
    [SerializeField] float _maxIntarval;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //�e��
            if (_isBulletvelocity)
            {
                if (BulletScript._speed <= _maxSpeed)
                {
                    BulletScript._speed *= 1.2f;
                }
                Destroy(gameObject);
            }
            //�C���^�[�o���ύX
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
