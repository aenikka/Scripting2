using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watchman : MonoBehaviour
{

    int state = 0; // 0 = Patrol
    [SerializeField] Transform path;
    Transform[] nodes;
    int index = 0;
    [SerializeField] public float patrolSpeed = 1.5f, chaseSpeed = 4f;
    public float currentSpeed = 0;
   public Renderer renderer;
    public AudioSource song;

    Transform target; // A dónde tengo que ir. Esto va cambiando

    private IWatchmanStated m_CurrentState;

    void Awake()
    {
        renderer = GetComponent<Renderer>();
        song = GetComponent<AudioSource>();
        m_CurrentState = new Patroling();
        m_CurrentState.Execute(this);
    }

    public void Patroling()
    {
        m_CurrentState = new Patroling();
        m_CurrentState.Execute(this);
    }

    public void Alert()
    {
        m_CurrentState = new Alert();
        m_CurrentState.Execute(this);
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
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < 0.5f)
        {
            index = (index + 1) % nodes.Length;
            target = nodes[index];
        }

        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, currentSpeed * Time.deltaTime * 10);

        transform.position += transform.forward * currentSpeed * Time.deltaTime;
    }

  

}
