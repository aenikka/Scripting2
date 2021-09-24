using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    int state = 0; // 0 = Patrol
    [SerializeField] Transform path;
    Transform[] nodes;
    int index = 0;
    [SerializeField] float patrolSpeed = 1.5f, chaseSpeed = 4f;
    float currentSpeed = 0;
    Renderer renderer;

    Transform target; // A dónde tengo que ir. Esto va cambiando


    void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    void Start()
    {

        nodes = new Transform[path.childCount];
        for (int i = 0; i < path.childCount; i++)
        {
            nodes[i] = path.GetChild(i);
        }

        target = nodes[0];
        currentSpeed = patrolSpeed;
    }

    void Update()
    {

        if (state == 0)
        {
            Debug.Log("state 0");
            renderer.material.color = Color.blue;
            currentSpeed = patrolSpeed;
            Movement();
            if (Input.GetButtonDown("Fire1"))
            {
                state = 1;
            }
        }
        else if (state == 1)
        {
            Debug.Log("state 1");
            renderer.material.color = Color.red;
            currentSpeed = chaseSpeed;
            Movement();
            if (Input.GetButtonDown("Fire1"))
            {
                state = 0;
            }

        }

        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, currentSpeed * Time.deltaTime * 10);

        transform.position += transform.forward * currentSpeed * Time.deltaTime;
    }

    public void Movement()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < 0.5f)
         {
         index = (index + 1) % nodes.Length;
        target = nodes[index];
         }
    }

}
