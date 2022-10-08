using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject[] _itemPrefab;
    [SerializeField] Transform _muzzlePosition;
    [SerializeField] GameObject _effect;
    GameObject _player;
    NavMeshAgent _nav;
    [SerializeField] int _score;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _nav = GetComponent<NavMeshAgent>();
        _nav.SetDestination(_player.transform.position);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            int n = Random.Range(0, _itemPrefab.Length);
            StartCoroutine(BulletHit(n, collision));
        }
    }
    IEnumerator BulletHit(int N, Collision collision)
    {
        GameObject Item =  Instantiate(_itemPrefab[N]);
        Item.transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        GameObject Effect = Instantiate(_effect);
        Effect.transform.position = new Vector3(transform.position.x, 3, transform.position.z);
        Effect.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        Gamemanager.AddScore(_score);
        yield return new WaitForSeconds(0.1f);
        //Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
