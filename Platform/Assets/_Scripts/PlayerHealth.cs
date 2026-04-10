using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Vida maxima del jugador
    public int maxHealth;

    // Vida actual del jugador
    private int health;

    // Almacena el animator
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // La vida actual es igual a la vida maxima
        health = maxHealth;

        // Se almacena el componente del Animator en la variable
        animator = GetComponent<Animator>();
    }

    // Espera el tiempo en el que el jugador no puede recibir daño, después de recibirlo.
    IEnumerator WaitForDamage()
    {
        // Se eliminan las coliciones
        Physics2D.IgnoreLayerCollision(3, 6, true);

        // Se ejecuta la animación de daño.
        animator.SetBool("isHit", true);

        // Se restan las vidas.
        health--;

        // Se esperan los segundos que dura la animacion segundos.
        yield return new WaitForSeconds(1.1f);

        // Vuelve a la animación anterior.
        animator.SetBool("isHit", false);

        // Se activan de nuevo las coliciones
        Physics2D.IgnoreLayerCollision(3, 6, false);
    }

    // Método para que se ejecute la corrutina.
    public void GetDamage()
    {
        // Si la vida es mayor a 1
        if (health > 1)
        {
            // Se inicializa la corrutina
            StartCoroutine(WaitForDamage());
        }
        else
        {
            // Se destruye el jugador. Aqui ponen lo que quieren que pase cuando el jugador muera
            Destroy(gameObject);
        }

    }
}
