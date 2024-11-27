using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    //Npc Healt
    public int healh = 5;
    //Npc Healt
    public int level = 1;
    //Npc Healt
    public float speed = 1.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        healh = healh + level;
        Debug.Log("Lives: " + healh);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = this.transform.position;

        newPosition.z = newPosition.z + speed * Time.deltaTime;

        this.transform.position = newPosition;
    }
}
