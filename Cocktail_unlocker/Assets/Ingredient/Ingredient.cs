using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public Color color;
    public bool isLiquid = true;
    public float viscosity = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        color = GetComponentInChildren<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
