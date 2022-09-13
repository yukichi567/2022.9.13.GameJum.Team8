using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject _bulletPrefab;
    float _timer;
    [SerializeField] public static float _interval;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(Input.GetMouseButtonDown(0)&&_timer > _interval)
        {
            _timer = 0;
            GameObject _bullet = Instantiate(_bulletPrefab);
            _bullet.GetComponent<BulletScript>().Shoot(new Vector3(0, 200, 2000));
        }
    }
}
