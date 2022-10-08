using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenSquare : MonoBehaviour
{
    /// <summary>ïœÇ¶ÇΩÇ¢ÉVÅ[ÉìÇÃñºëO</summary>
    [SerializeField] string _changeScene;
    [SerializeField] GameObject _clickAudio;

    public void LoadScenes()
    {
        StartCoroutine(SceneMove());
    }
    IEnumerator SceneMove()
    {
        Instantiate(_clickAudio);
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(_changeScene);
    }
}
