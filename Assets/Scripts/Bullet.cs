using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField]private float _BuletDistance,BulleteSpeed;
    private void Start()
    {
        gameObject.transform.rotation = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().rotation;//take player rotation
    }
    private void FixedUpdate()
    {
        transform.Translate( Vector3.up * BulleteSpeed * Time.fixedDeltaTime);//move bullete straight
    }
    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Enemy"|| Other.gameObject.layer==10)
        {
            Destroy(gameObject);
        }
    }
}
