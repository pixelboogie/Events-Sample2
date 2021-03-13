using UnityEngine;
using System.Collections;

public class MyTeleportScript : MonoBehaviour 
{
    void OnEnable()
    {
        MyClickEvent.OnAnythingClicked += Teleport;
    }


    void OnDisable()
    {
        MyClickEvent.OnAnythingClicked -= Teleport;
    }


    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}