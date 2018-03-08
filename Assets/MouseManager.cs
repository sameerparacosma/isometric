using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {
    public GameObject selectedObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo))
        {
            GameObject hitObject = hitInfo.transform.root.gameObject;

            SelectObject(hitObject);
        }
        else
        {
            ClearSelection();
        }
	}

    private void ClearSelection()
    {

        selectedObj = null;
    }

    private void SelectObject(GameObject hitObject)
    {
        if (hitObject != null)
        {
            if (hitObject == selectedObj)
            { return; }
        
            ClearSelection();
        }
        selectedObj = hitObject;
    }
}
