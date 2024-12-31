using UnityEngine;

public class BystanderPanda : MonoBehaviour
{
    BoxCollider2D boxCollider;
    Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            anim.SetBool("Hit", true);
            print("You shot the Panda!");
        }
    }
}