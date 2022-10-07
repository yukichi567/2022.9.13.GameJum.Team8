using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerScript : MonoBehaviour
{
    public static int _playerHp = 3;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] public static float _intarval = 0.1f;
    [SerializeField] Transform _muzzlePosition;
    [SerializeField] int _bullet;
    [SerializeField] public int _maxBullet;
    [SerializeField] Text _bulletCount;
    float _timer;
    int y = 0;
    void Update()
    {
        _bulletCount.text = $"{_bullet}/{_maxBullet}";
        if (Gamemanager._isGame)
        {
            _timer += Time.deltaTime;
            if (Input.GetMouseButton(0))
            {
                if (_bullet >= 1)
                {
                    
                    if (_timer > _intarval)
                    {
                        _bullet--;
                        _timer = 0;
                        GameObject bullet = Instantiate(_bulletPrefab);
                        bullet.transform.position = _muzzlePosition.position;
                        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                        Vector3 _worldDir = _ray.direction;
                        bullet.GetComponent<BulletScript>().Shoot(_worldDir.normalized * BulletScript._speed);
                    }
                }

            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                _bullet = _maxBullet;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A");
                y -= 90;
                transform.DOLocalRotate(new Vector3(0f, y, 0f),1f,RotateMode.Fast);
                //transform.rotation = Quaternion.Euler(0f, y, 0f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("D");
                y += 90;
                transform.DOLocalRotate(new Vector3(0f, y, 0f), 1f, RotateMode.Fast);
                //transform.rotation = Quaternion.Euler(0f, y, 0f);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            _playerHp -= 1;
            Destroy(other.gameObject);
        }
    }
}