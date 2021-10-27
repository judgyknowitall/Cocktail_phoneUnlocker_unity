using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DragAndDrop : MonoBehaviour
{
    bool moveAllowed;
    Collider2D col;
    Vector2 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        originalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Get user touch!
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);


            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Allow Move Ingredient!
                    Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                    if (col == touchedCollider)
                    {
                        moveAllowed = true;

                        // Change Text
                        int id = GetComponent<Ingredient>().id;
                        FindObjectOfType<Text>().GetComponent<Label>().UpdateText(id);
                    }
                    break;

                case TouchPhase.Moved:
                    if (moveAllowed)
                    {
                        transform.position = new Vector2(touchPosition.x, touchPosition.y);
                    }
                    break;

                case TouchPhase.Ended:
                    moveAllowed = false;
                    transform.position = originalPos;
                    FindObjectOfType<Text>().GetComponent<Label>().RemoveText();
                    break;
            }
        }
    }
}
