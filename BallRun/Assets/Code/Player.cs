using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float turnSpeed;  // User Control
    bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            gameOver = true;
        } 
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }

        if(gameOver)
        {
            Time.timeScale = 0;
            return;
        }

        if(transform.position.x < -4 || transform.position.x > 4)
        {
            transform.Translate(0, -10*Time.deltaTime, 0);
        }

        if(transform.position.y < -20)
        {
            gameOver = true;
        }

        float x = Input.GetAxis("Horizontal");
        transform.Translate(x*turnSpeed*Time.deltaTime, 0, speed*Time.deltaTime);
        // float v = Input.GetAxis("Vertical");
        // float h = Input.GetAxis("Horizontal");
        // transform.Translate(h*speed*Time.deltaTime, 0, v*speed*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other) {
        // if(other.name == "Barrier")
        if(other.name == "Barrier")
        {
            gameOver = true;
        }
        if(other.name == "end")
        {
            Debug.Log("Well Done!");
            gameOver = true;
        }
    }
}
