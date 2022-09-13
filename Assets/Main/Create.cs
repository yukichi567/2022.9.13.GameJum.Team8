using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Create : MonoBehaviour
{
    [SerializeField] GameObject[] _objectPrefab;
    BoxCollider _bc;
    float _timer;
    [SerializeField]float _intarval;
    float _x;
    //float _y;
    int n;

    // Start is called before the first frame update
    void Start()
    {
        _bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _x = Random.Range((-_bc.size.x) / 2, (_bc.size.x) / 2);
        //_y = Random.Range((-_bc.size.y) / 2, (_bc.size.y) / 2);
        if (_timer >= _intarval)
        {
            n = Random.Range(0, _objectPrefab.Length);
            GameObject Enemy = Instantiate(_objectPrefab[n]);
            Enemy.transform.position = new Vector3(_x, _bc.transform.position.y, _bc.transform.position.z);
            _timer = 0;
        }
    }
}
