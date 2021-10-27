using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public int id;
    public Color color;


    // Start is called before the first frame update
    void Start()
    {
        color = GetComponentInChildren<SpriteRenderer>().color;
    }
}
