using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static int _playerHp = 3;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float _intarval;
    float _timer;

    void Update()
    {
        _timer += Time.deltaTime;
        if (Input.GetMouseButton(0) && _timer > _intarval)
        {
            if (_timer > _intarval)
            {
                _timer = 0;
                GameObject _bullet = Instantiate(_bulletPrefab);
                _bullet.transform.position = transform.position;
                Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 _worldDir = _ray.direction;
                _bullet.GetComponent<BulletScript>().Shoot(_worldDir.normalized * BulletScript._speed);
            }

        }
    }
}
