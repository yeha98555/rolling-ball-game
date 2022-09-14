using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject endUI;

    // Start is called before the first frame update
    void Start()
    {
        endUI = GameObject.Find("EndUI");
        endUI.transform.localScale = new Vector3(0, 0, 0);
        // endUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.name == "Player")
        {
            Debug.Log("Well Done!");

            // endUI.SetActive(false);
            endUI.transform.localScale = new Vector3(1, 1, 1);
            Time.timeScale = 0;
        }
    }
}
