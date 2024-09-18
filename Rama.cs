using UnityEngine;

public class Rama : MonoBehaviour
{
    public Animator animator;
    public GameObject arrowPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Attack");
            ShootArrow();
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            animator.Play("Walk");
        }
        else
        {
            animator.Play("Idle");
        }
    }

    void ShootArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(10, 0); // Arrow flies right
    }
}
