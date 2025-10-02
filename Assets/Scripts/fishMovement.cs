using UnityEngine;

public class ObstacleMovement2D : MonoBehaviour
{
    public Transform[] puntos;   
    public float velocidad = 3f; 

    private int indiceActual = 0;

    void Update()
    {
        if (puntos.Length == 0) return;

        transform.position = Vector2.MoveTowards(
            transform.position,
            puntos[indiceActual].position,
            velocidad * Time.deltaTime
        );

        
        if (Vector2.Distance(transform.position, puntos[indiceActual].position) < 0.1f)
        {
            indiceActual++;
            if (indiceActual >= puntos.Length)
            {
                indiceActual = 0; 
            }
        }
    }
}
