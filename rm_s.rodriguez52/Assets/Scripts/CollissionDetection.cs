using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionDetection : MonoBehaviour
{
    public Color collisionColor=Color.red;  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnColissionEnter(Collision collision){
    Renderer renderer= collision.gameObject.GetComponent<Renderer>();

    if (renderer!=null){
        renderer.material.color=collisionColor;
        }


    }

}
