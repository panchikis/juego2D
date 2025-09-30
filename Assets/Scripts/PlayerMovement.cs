using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //El serializeField es una opci�n que permite mantener 
    [SerializeField] private float velocidad;
    private Vector2 ejeControl;
    private Rigidbody2D fisicas;
    private Animator animator;
    private SpriteRenderer sprite;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fisicas = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        ejeControl = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = new Vector2(ejeControl.x, ejeControl.y);
        //Aqu� realmente le estoy diciendo que se mueva segun el vector programado
        transform.Translate(movimiento * velocidad * Time.deltaTime);
        //Ahora voy a cambiar el valor del par�metro del animator seg�n ejeControl.x
        //Para cambiar el valor de un Parameter del animator, usamos el objeto y llamamos a un m�todo set.
        //EJEMPLO: s� creamos un parameter en Unity de tipo float, para modificarlo llamaremos al m�todo 
        //SetFloat 
        animator.SetBool("nadar", ejeControl.x != 0 || ejeControl.y != 0);
        if (ejeControl.x < 0)
        {
            sprite.flipX = true;
        }
        else if (ejeControl.x > 0)
        {
            sprite.flipX = false;
        }
    }
}
