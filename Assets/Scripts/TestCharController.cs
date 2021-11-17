using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharController : MonoBehaviour
{
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    public int Jump = 15;
    private Animator Anim;
    private Vector3 DirectionDeplacement = Vector3.zero;
    
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;
                
        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);

        if(Input.GetKey(KeyCode.W))
        {
            Anim.SetBool("Run", true);
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            Anim.SetBool("Run", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            DirectionDeplacement.y = Jump;
            Anim.SetTrigger("Jumping");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
