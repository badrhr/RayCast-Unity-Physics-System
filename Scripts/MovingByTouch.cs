using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class MovingByTouch : MonoBehaviour
{ 
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x +   Time.deltaTime * touch.deltaPosition.x * 1E-1f,
                    transform.position.y +   Time.deltaTime * touch.deltaPosition.y * 1E-1f,
                    transform.position.z
                    );
            }
        }
    }
}
