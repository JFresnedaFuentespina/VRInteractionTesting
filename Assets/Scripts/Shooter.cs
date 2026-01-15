using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject projectilePrefab;
    public Transform spawnPoint;
    private float bulletSpeed = 10f;
    private OVRInput.Controller controller = OVRInput.Controller.RTouch; // Right-hand controller
    private OVRInput.Button button = OVRInput.Button.PrimaryIndexTrigger; // Index trigger button

    // Update is called once per frame
    void Update()
    {
        bool buttonPressed = OVRInput.GetDown(button, controller);
        if (buttonPressed)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(projectile, 5f); // Destroy the projectile after 5 seconds
    }
}
