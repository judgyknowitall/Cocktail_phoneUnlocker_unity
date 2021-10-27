using UnityEngine;

public class Cup_logic : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Touched!");
        if (collision.tag == "Ingredient")
        {
            Ingredient ingredient = collision.gameObject.GetComponent<Ingredient>();

            // Change colour logic
            spriteRenderer.color = ingredient.color;

            // Ask Manager to check password
            FindObjectOfType<GameManager>().AddToCombo(ingredient.id);
        }
    }
}
