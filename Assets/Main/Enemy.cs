using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject[] _itemPrefab;
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
            int n = Random.Range(0, _itemPrefab.Length);
            StartCoroutine(BulletHit(n, collision));
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    IEnumerator BulletHit(int N, Collision collision)
    {
        Instantiate(_itemPrefab[N], transform.position, transform.rotation);
        Gamemanager.AddScore(_score);
        yield return new WaitForSeconds(0.5f);
        //Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
