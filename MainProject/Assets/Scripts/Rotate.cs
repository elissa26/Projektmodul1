using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float rotationSpeedMultiplier = 100f;
    bool dragging = false;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody> ();
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
        dragging = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0)){
            dragging = false;
        }
    }

    void FixedUpdate(){
        if (dragging){
            float x = Input.GetAxis("Mouse X")*rotationSpeedMultiplier*Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y")*rotationSpeedMultiplier*Time.fixedDeltaTime;

            rb.AddTorque (Vector3.down*x);
            rb.AddTorque (Vector3.right*y);
        }
    }
}
