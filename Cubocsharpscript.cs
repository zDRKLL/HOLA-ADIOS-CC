using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubocsharpscript : MonoBehaviour
{
   public int health = 5;
    public int level = 1;
    public float speed = 30.2f;
    Vector3 newposition;
    // Start is called before the first frame update
    void Start()
    {
        newposition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        newposition.z  += speed * Time.deltaTime;
        transform.position = newposition;
    }
}
