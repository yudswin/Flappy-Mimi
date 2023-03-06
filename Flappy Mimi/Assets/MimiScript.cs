using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimiScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public LogicScript logic;

    private float deadZone = -45;
    public bool mimiIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (transform.position.y < deadZone) 
        {
            Debug.Log("mimi dead");
            mimiIsAlive = false;
            logic.gameOver();
        }

        if (Input.GetKeyDown(KeyCode.Space) && mimiIsAlive) {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        mimiIsAlive = false;
    }
}
