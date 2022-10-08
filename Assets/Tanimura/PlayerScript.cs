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
    [SerializeField] GameObject _shootAudio;
    [SerializeField] GameObject _reroadAudio;
    [SerializeField] GameObject _missingAudio;
    Gamemanager _gamemanager;
    float _timer;
    float _rotationTimer;
    int y = 0;
    private void Start()
    {
        _gamemanager = GameObject.FindObjectOfType<Gamemanager>();
    }
    void Update()
    {
        _bulletCount.text = $"{_bullet}/{_maxBullet}";
        if (Gamemanager._isGame)
        {
            _timer += Time.deltaTime;
            _rotationTimer += Time.deltaTime;
            if (Input.GetMouseButton(0))
            {
                if (_bullet >= 1)
                {
                    if (_timer > _intarval)
                    {
                        _bullet--;
                        _timer = 0;
                        Instantiate(_shootAudio);
                        GameObject bullet = Instantiate(_bulletPrefab);
                        bullet.transform.position = _muzzlePosition.position;
                        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                        Vector3 _worldDir = _ray.direction;
                        bullet.GetComponent<BulletScript>().Shoot(_worldDir.normalized * BulletScript._speed);
                    }
                }
                else
                {
                    Instantiate(_missingAudio);
                }
            }
            if(Input.GetKeyDown(KeyCode.R) && !Input.GetMouseButton(0))
            {
                _bullet = _maxBullet;
                Instantiate(_reroadAudio);
            }
            if (_rotationTimer >= 0.3f)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Debug.Log("A");
                    y -= 90;
                    //transform.rotation = Quaternion.Euler(0f, y, 0f);
                    transform.DOLocalRotate(new Vector3(0f, y, 0f), 1f, RotateMode.Fast);
                    _rotationTimer = 0;
                    if (y <= -360)
                    {
                        y = 0;
                    }
                    Debug.Log(y);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Debug.Log("D");
                    y += 90;
                    //transform.rotation = Quaternion.Euler(0f, y, 0f);
                    transform.DOLocalRotate(new Vector3(0f, y, 0f), 1f, RotateMode.Fast);
                    _rotationTimer = 0;
                    if(y >= 360)
                    {
                        y = 0;
                    }
                    Debug.Log(y);
                }
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