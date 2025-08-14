using UnityEditor;
using UnityEngine;

public class FPController : MonoBehaviour
{ // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] Transform View = null;

    float cameraRotation = 0f;

    CharacterController controls = null;
    void Start()
    {
        controls = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("MouseY"), Input.GetAxis("MouseX"));

        cameraRotation += mouseDelta.y;
        cameraRotation = Mathf.Clamp(cameraRotation, -90f, 90f);

        transform.Rotate(Vector3.up * mouseDelta.x);
        { //movement
            Vector2 input = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));

            Vector3 velocity = (transform.forward * input.y + transform.right * input.x);
            controls.Move(Time.deltaTime * velocity);
        }
    
                



   

    }
}
