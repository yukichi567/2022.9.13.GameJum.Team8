using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static int _playerHp = 3;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] public static float _intarval = 1f;
    float _timer;

    void Update()
    {
        if (Gamemanager._isGame)
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _playerHp -= 1;
            Destroy(collision.gameObject);
        }
    }
}