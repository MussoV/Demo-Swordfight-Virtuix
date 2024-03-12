using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCtest2 : MonoBehaviour
{
float countDown = 5.0f;

// Use this for initialization
void Start () {

}

void Update () {
    if (countDown > 0.0f) {
    transform.position += Vector3.forward * Time.deltaTime;
    countDown -= Time.deltaTime;
}

    else if (countDown <= 0.0f) {
        transform.position += Vector3.back * Time.deltaTime;
    countDown += Time.deltaTime;
    }
}
}
