using System;
using UnityEngine;

public class MyClickEvent : MonoBehaviour
{

    private Collider collider;

    public delegate void ClickAction();
    public static event ClickAction OnAnythingClicked;

    private void Awake()
    {
        collider = GetComponent<Collider>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if(collider.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                OnAnythingClicked();
            }
        }
    }



}
