using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnParticleCollision()
    {
        Destroy(this.gameObject);
    }
}
