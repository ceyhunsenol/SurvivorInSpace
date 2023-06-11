
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 offset; // Kamera ile Character arasındaki mesafe
    public float smootSpeed = 0.125f;
    public Transform character;
  

    



    // private void Start() => offset = transform.position - Character.position;
    // Character ile kamera arasındaki mesafeyi kaydet

    // private void LateUpdate() => transform.position = Character.position + offset;

    private void LateUpdate()
    {
       transform.position = character.position + offset;
        
    }
}
