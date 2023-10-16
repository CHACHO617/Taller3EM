using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject bulletPrefab;
    public Transform cannonTransform;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        rb.velocity = movement * moveSpeed;

        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet(); 
        }

        void FireBullet()
        {
            if(bulletPrefab != null && cannonTransform != null)
            { 
                GameObject bullet = Instantiate(bulletPrefab, cannonTransform.position, cannonTransform.rotation);
            }

        }
    }
}

