using UnityEngine;

public class ObjectPicker : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 cursorOffset;
    public Texture2D handCursor;

    private void OnMouseEnter()
    {
        // if(SimulationManager.ins)
           Cursor.SetCursor(handCursor, cursorOffset, cursorMode);
      

    }

    private void OnEnable()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000))
        {
            //Debug.Log(hit.transform.name);
            //Debug.Log("mouse hitting = "+hit.transform.name);

            if(hit.transform.name == this.transform.name)
            {
                //print("hitting active object");
                OnMouseEnter();
            }
        }
    }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }
    

    private void OnMouseExit()
    {
      //  if (SimulationManager.ins)
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

}