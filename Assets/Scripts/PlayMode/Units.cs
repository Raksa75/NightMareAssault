using UnityEngine;
using UnityEngine.Splines;

public class Unit : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SplineAnimate m_splineAnimate;

    [Header("Stats")]
    [SerializeField] private float m_health;
    [SerializeField] private float m_attack;
    [SerializeField] private float m_cost;
    [SerializeField] private float m_attackCooldown;
    [SerializeField] private bool m_type1;

    private SplineContainer m_splineContainer;

    public void Init(SplineContainer spline)
    {
        m_splineContainer = spline;
        m_splineAnimate.Container = m_splineContainer;
        m_splineAnimate.Play();
    }
    public void TakeDamage(float damage, Transform damageSource)
    {
        m_health -= damage;

        if (m_health <= 0)
        {
            m_health = 0;
            DestroyInvo();
        }
    }

    public void DestroyInvo()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EnemyTower");

        if (other.CompareTag("Enemy"))
        {
            m_splineAnimate.enabled = false;
        }
    }
}

