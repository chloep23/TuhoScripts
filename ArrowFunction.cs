// Arrow Function - 
// Name: Chloe Park 
// Aimed Completion Date: October 17, 2023
// Purpose: Function of an Arrow 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_function : MonoBehaviour
{
    public float arrowPositionOffset;
    public GameObject arrowPrefab;
    public LineRenderer[] lineRenderers;
    public Transform[] stripPositions;
    public Transform idlePosition;
    public Transform center;

    public Vector3 currentPosition;

    bool isMouseDown;
    Rigidbody arrow;
    Collider arrowCollider;

    // Used for initialization 
    void Start()
    {
        lineRenderers[0].positionCount = 2; //vertices count 
        lineRenderers[1].positionCount = 2; //vertices count 
        lineRenderers[0].SetPosition(0, stripPositions[0].position);
        lineRenderers[1].SetPosition(0, stripPositions[1].position);
   
        CreateArrow();
    }

    // Arrow Production - 
    void CreateArrow()
    {
        arrow = Instantiate(arrowPrefab).GetComponent<Rigidbody>();
        arrowCollider = arrow.GetComponent<Collider>();

        arrowCollider.enabled = false;

        ResetStrips();
    }

    // Update is called once per frame  
    void Update()
    {
        if (isMouseDown)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.y = 55;
            mousePosition.z = 294;
            mousePosition.x = 53;

            currentPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            currentPosition = mousePosition;
            SetStrips(currentPosition);

        }
        else
        {
            ResetStrips();
        }
    }

    // Mouse Controls -  
    void OnMouseDown()
    {
        isMouseDown = true;
    }

    void OnMouseUp()
    {
        isMouseDown = false;
        currentPosition = idlePosition.position;
    }

    // Strip Controls - 
    void ResetStrips()
    {
        currentPosition = idlePosition.position;
        SetStrips(currentPosition);
    }

    void SetStrips(Vector3 position)
    {
        lineRenderers[0].SetPosition(1, position);
        lineRenderers[1].SetPosition(1, position);
        
        if(arrow) 
        {
            Vector3 dir = center.position - position;
            arrow.transform.position = position;
            arrow.transform.position = position + dir.normalized * arrowPositionOffset;
        }
        Debug.Log(arrow.transform.position);
    }
}
