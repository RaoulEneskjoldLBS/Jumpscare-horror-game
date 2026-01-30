using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nowayback : MonoBehaviour
{

    public GameObject nowaybackwall;

    private void OnTriggerEnter(Collider other)
    {
        nowaybackwall.SetActive(true);
    }
}
