using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Create : MonoBehaviour
{
    [SerializeField] Transform[] _createposition;
    [SerializeField] GameObject[] _objectPrefab;
    BoxCollider _bc;
    float _timer;
    [SerializeField]public static float _intarval = 1f;
    float _x;
    //float _y;
    int n;
    int posotion;

    // Start is called before the first frame update
    void Start()
    {
        _bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager._isGame)
        {
            _timer += Time.deltaTime;
            _x = Random.Range((-_bc.size.x) / 2, (_bc.size.x) / 2);
            //_y = Random.Range((-_bc.size.y) / 2, (_bc.size.y) / 2);
            if (_timer >= _intarval)
            {
                int position = Random.Range(0, _createposition.Length);
                int n = Random.Range(0, _objectPrefab.Length);
                GameObject Enemy = Instantiate(_objectPrefab[n]);
                Enemy.transform.position = _createposition[position].position;
                //Enemy.transform.position = new Vector3(_x, _bc.transform.position.y, _bc.transform.position.z);
                _timer = 0;
            }
        }
    }
}
