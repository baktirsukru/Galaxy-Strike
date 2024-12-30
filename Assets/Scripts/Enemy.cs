using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] float hitpoint = 6;
    [SerializeField] int scoreValue = 10;
    ScoreBoard scoreboard;

    private void Start()
    {
        scoreboard = FindFirstObjectByType<ScoreBoard>();
    }

    void OnParticleCollision()
    {
        ProcessHit();
    }

    public void ProcessHit()
    {
        hitpoint--;

        if (hitpoint <= 0)
        {
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            scoreboard.IncreaseScore(scoreValue);
        }
    }
}
