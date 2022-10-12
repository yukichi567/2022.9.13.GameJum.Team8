using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenSquare : MonoBehaviour
{
    /// <summary>ïœÇ¶ÇΩÇ¢ÉVÅ[ÉìÇÃñºëO</summary>
    [SerializeField] string _changeScene;
    [SerializeField] GameObject _clickAudio;
    [SerializeField] GameObject _open;
    [SerializeField] GameObject _close;
    [SerializeField] GameObject _open2;
    [SerializeField] GameObject _close2;

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
    public void SetActive()
    {
        _open.gameObject.SetActive(true);
        _close.gameObject.SetActive(false);
        Instantiate(_clickAudio);
    }
    public void SetActiveHelp()
    {
        _open.gameObject.SetActive(true);
        _close.gameObject.SetActive(false);
        _open2.gameObject.SetActive(true);
        _close2.gameObject.SetActive(false);
        Instantiate(_clickAudio);
    }
}
