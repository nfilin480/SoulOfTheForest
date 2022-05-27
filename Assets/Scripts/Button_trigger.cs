using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_trigger : MonoBehaviour
{
    public GameObject activeFrame;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            activeFrame.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player")){
            activeFrame.SetActive(false);
        }
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
