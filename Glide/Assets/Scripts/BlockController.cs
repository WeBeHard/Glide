using UnityEngine;

public class BlockController : MonoBehaviour
{
    /*  Detect if object was clicked
     *  Match object transform to mouse transform
     */
    private Vector3 distance;
    Transform objectPosition;
    Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
    }

    public void OnMouseDown()
    {
        // Distance from camera to object
        distance = Camera.main.WorldToScreenPoint(transform.position);
    }

    public void OnMouseDrag()
    {
        // Get position of mouse while moving it
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance.z);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        objectPosition.x = (int)(Mathf.Round(objectPosition.x));
        objectPosition.y = (int)(Mathf.Round(objectPosition.y));
        transform.position = objectPosition;
    }

    public void OnMouseExit()
    {
        if(transform.position.x < 0 || transform.position.x > 10 || transform.position.y < 0 || transform.position.y > 10)
        {
            transform.position = originalPosition;
        }
    }
}
