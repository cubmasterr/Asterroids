using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float EnemySpeed;
    [SerializeField] private Transform Target;
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, EnemySpeed * Time.fixedDeltaTime);
    }
}
