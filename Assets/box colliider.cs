using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxcolliider : MonoBehaviour
{
    public GameObject Text;
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("aaaaaaaaaaaaaaaaa");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("bbbbbbbbb");

            Text.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Text.gameObject.SetActive(false);
        }
    }
}