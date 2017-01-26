using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class StatePatternEnemy : MonoBehaviour 
{
    public float searchingTurnSpeed = 120f;
    public float searchingDuration = 4f;
    public float sightRange = 20f;
    public Transform[] wayPoints;
    public Transform eyes;
    public Vector3 offset = new Vector3 (0,.5f,0);
    public MeshRenderer meshRendererFlag;
    public Material fullHealth;
    public Material halfHealth;
    public Material lowHealth;
    public Material dead;
    public float health = 10;
    public SkinnedMeshRenderer body;
    public BoxCollider triggerBox;


    [HideInInspector] public Transform chaseTarget;
    [HideInInspector] public IEnemyState currentState;
    [HideInInspector] public ChaseState chaseState;
    [HideInInspector] public AlertState alertState;
    [HideInInspector] public PatrolState patrolState;
    [HideInInspector] public NavMeshAgent navMeshAgent;

    private void Awake()
    {
        chaseState = new ChaseState (this);
        alertState = new AlertState (this);
        patrolState = new PatrolState (this);

        navMeshAgent = GetComponent<NavMeshAgent> ();
    }

    // Use this for initialization
    void Start () 
    {
        currentState = patrolState;
    }
    
    // Update is called once per frame
    void Update () 
    {
        currentState.UpdateState ();
    }

    public void gotHit(){
    	if(health>0){
    		health--;
    	}else{
    		body.material = dead;
    	}

    	if(health>=10){
        	body.material = fullHealth;
        }else if(health>= 5){
        	body.material = halfHealth;
        }else if(health<=2 && health>0){
        	body.material = lowHealth;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter (other);
    }
}