using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Vector3 _position;
    public Vector3 _screenToWorldPointPosition;
    public static int _playerHp = 3;
    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _muzzle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _position = Input.mousePosition;
        _screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(_position);
        _muzzle.transform.position = _screenToWorldPointPosition;
    }
}
