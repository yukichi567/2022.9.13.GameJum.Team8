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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //�e��
            if (_isBulletvelocity)
            {
                //�e�ɂ��Ă�X�N���v�g��������

            }
            //�C���^�[�o���ύX
            else if(_isinterval)
            {
                //�v���C���[�ɂ��Ă�X�N���v�g��������

            }
        }
    }
}
