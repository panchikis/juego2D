using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mina"))
        {
            Destroy(collision.gameObject);
            Perder();
        }
    }
    void Perder()
    {
        animator.SetTrigger("muerte");
        rigidbody.bodyType = RigidbodyType2D.Static;
    }

    private void ReiniciarNivel()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}