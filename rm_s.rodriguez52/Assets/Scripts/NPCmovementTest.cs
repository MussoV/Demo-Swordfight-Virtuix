using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmovementTest : MonoBehaviour
{
    public float speed =5f;
    public float distance=10f;

    private Vector3 startPos;
    private float currentDistance;

    // Start is called before the first frame update
    void Start()
    {
     startPos=transform.position;
     currentDistance=0f;

    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
