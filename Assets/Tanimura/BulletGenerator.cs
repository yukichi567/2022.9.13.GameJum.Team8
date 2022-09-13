using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject _bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject _bullet = Instantiate(_bulletPrefab);
            _bullet.GetComponent<BulletScript>().Shoot(new Vector3(0, 200, 2000));
        }
    }
}
