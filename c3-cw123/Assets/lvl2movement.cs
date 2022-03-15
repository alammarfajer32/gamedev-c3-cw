using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl2movement : MonoBehaviour
{
    // player script

    void OnMouseDrag(){
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 PlayerPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = PlayerPos;
    }

    void OnCollisionEnter2D(Collision2D other){
        SceneManager.LoadScene("lvl1");
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("lvl2");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
