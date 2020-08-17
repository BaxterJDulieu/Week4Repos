using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 0;
    System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
        ++i;
        Debug.Log(gameObject.name + ":" + i);

        if ((i == 100) && gameObject.tag == "Red")
        {
            gameObject.SetActive(false);
        }

        if ((i == random.Next(200,250)) && gameObject.tag == "Blue")
        {
            rend.enabled = false;
        }
    }
    
    
}
