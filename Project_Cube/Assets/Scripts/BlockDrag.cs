using UnityEngine;
using System.Collections.Generic;

public class BlockDrag : MonoBehaviour
{
    public Vector3 mousePosition;
    
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
    }
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition- mousePosition);
    }
}
