using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(End());
    }
    private IEnumerator End()
    {
        yield return new WaitForSeconds(0f);
        SceneManager.LoadScene(3);
    }
}
