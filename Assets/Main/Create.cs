using UnityEngine;

public class Create : MonoBehaviour
{
    [SerializeField] Transform[] _createposition;
    [SerializeField] GameObject[] _objectPrefab;
    [SerializeField]public static float _intarval = 1.5f;
    BoxCollider _bc;
    float _timer;
    float _x;
    void Update()
    {
        if (Gamemanager._isGame)
        {
            _timer += Time.deltaTime;
            if (_timer >= _intarval)
            {
                
                int position = Random.Range(0, _createposition.Length);
                int n = Random.Range(0, _objectPrefab.Length);
                _bc = _createposition[position].GetComponent<BoxCollider>();
                float x = Random.Range(-(_bc.size.x) / 2, (_bc.size.x) / 2);
                GameObject Enemy = Instantiate(_objectPrefab[n]);
                Enemy.transform.position = new Vector3(_createposition[position].position.x + x, _createposition[position].position.y, _createposition[position].position.z);
                _timer = 0;
            }
        }
    }
}
