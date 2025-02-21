using UnityEngine;
using UnityEngine.Splines;


    public class Unit : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SplineAnimate m_splineAnimate;

    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Cost { get; set; }

    private SplineContainer m_splineContainer;

    public void Init(SplineContainer spline)
    {
        m_splineContainer = spline;
        m_splineAnimate.Container = m_splineContainer;
        m_splineAnimate.Play();
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

