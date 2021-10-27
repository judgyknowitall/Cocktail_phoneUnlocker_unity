using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup_logic : MonoBehaviour
{
    List<SpriteRenderer> fluids = new List<SpriteRenderer>();
    static Color invisible = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    int layer = 0;



    // Start is called before the first frame update
    void Start()
    {
        layer = 0; // Make sure this is reset

        foreach (Transform t in transform)
        {
            if (t.gameObject.name.Contains("Layer"))
            {
                SpriteRenderer s = t.gameObject.GetComponent<SpriteRenderer>();
                s.color = invisible;
                fluids.Add(s);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ingredient")
        {
            Ingredient ingredient = collision.gameObject.GetComponent<Ingredient>();

            // Change colour logic
            ChangeColor(ingredient.color);

            // Ask Manager to check password
            FindObjectOfType<GameManager>().AddToCombo(ingredient.id);
        }
    }

    void ChangeColor(Color color)
    {
        if (layer < fluids.Count)
        {
            fluids[layer].color = color;
            layer++;
        }
    }
}
