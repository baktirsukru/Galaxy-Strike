using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    bool isFiring = false;

    void Update()
    {
        ProcessFiring();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void ProcessFiring()
    {
       /*  var emissionModule = laser.GetComponent<ParticleSystem>().emission;
        emissionModule.enabled = isFiring; */
        
    }
}
