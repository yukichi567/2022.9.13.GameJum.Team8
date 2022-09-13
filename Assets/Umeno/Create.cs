using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    [SerializeField] GameObject[] _objectPrefab;
    BoxCollider2D _bc;
    float _timer;
    float _intarval;
    float _x;
    float _y;
    int n;

    // Start is called before the first frame update
    void Start()
    {
        _bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _x = Random.Range((-_bc.size.x) / 2, (_bc.size.x) / 2);
        //_y = Random.Range((-_bc.size.y) / 2, (_bc.size.y) / 2);
        n = Random.Range(0, _objectPrefab.Length);
        GameObject Enemy = Instantiate(_objectPrefab[n]);
        Enemy.transform.position = new Vector3(_x, _bc.transform.position.y, _bc.transform.position.z);
    }
}
