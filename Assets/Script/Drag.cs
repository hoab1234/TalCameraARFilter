using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public float rotate_spd = 100.0f;

   void OnMouseDrag()
    {
        float temp_x_acis = Input.GetAxis("Mouse X") * rotate_spd * Time.deltaTime;
        float temp_y_acis = Input.GetAxis("Mouse Y") * rotate_spd * Time.deltaTime;
        transform.Rotate(temp_y_acis, -temp_x_acis, 0, Space.World);
    }
}
