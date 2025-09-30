using UnityEngine;
using UnityEngine.UI;

public class coleccionables : MonoBehaviour
{
    private int collectionAmount= 0;
    [SerializeField] private Text textCollection;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
           collectionAmount++;
           textCollection.text = "PECES: " + collectionAmount;
            // Destruye el objeto coleccionable
            Destroy(collision.gameObject);
        }
    }
}