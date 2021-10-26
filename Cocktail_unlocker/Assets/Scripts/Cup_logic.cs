using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup_logic : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    List<int> currentCombo = new List<int>();
    private List<int> pswd = new List<int>() { 1, 2 } ;

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
            spriteRenderer.color = collision.gameObject.GetComponent<Ingredient>().color;

            // Check password
            if (currentCombo.Count == pswd.Count)
            {
                for (int i = 0; i < currentCombo.Count; i++) {
                    if (currentCombo[i] != pswd[i]) return;
                }

                // Password was correct!

            }

            
        }
    }
}
