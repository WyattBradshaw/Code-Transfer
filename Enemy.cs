using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("Enemy")]
    public GameObject pObj;
    public GameObject eProj;
    public Animator main;
    public AudioSource gulp;
    public AudioSource ass;
    public AudioClip hit;
    public AudioClip die;
    public int ehealth=3;
    public move pScript;
    public NavMeshAgent agent;
    public Transform ptrans;
    public LayerMask ground, wplayer;
    [Header("Patrol")]
    public Vector3 wP;
    bool wps;
    public float PatrolRange;
    [Header("Attack")]
    public float attackTimer;
    bool attacked;
    [Header("States")]
    public float sightRange, attackRange;
    public bool playerinSight, playerinAttack, pHiding,inAnim,ov;
    float x = 0;
    // Start is called before the first frame update
    void Awake()
    {
        pHiding = pScript.isHiding;
        ptrans = GameObject.Find("Player").transform;

    }
    private void Update()
    {
        playerinSight = Physics.CheckSphere(transform.position, sightRange, wplayer);
        playerinAttack = Physics.CheckSphere(transform.position, attackRange, wplayer);
        if (inAnim == false)
        {

            if (!playerinSight & !playerinAttack) Patrol();
            if (pHiding == false)
            {
                if (playerinSight & !playerinAttack) Chase();
                if (playerinAttack & playerinSight) Attack();
            }

        }

    }
    private void Newalk()
    {
        float rz = Random.Range(-PatrolRange, PatrolRange);
        float rx = Random.Range(-PatrolRange, PatrolRange);
        wP = new Vector3(transform.position.x + rx + transform.position.y, transform.position.z + rz);
        if (Physics.Raycast(wP, -transform.up, 2f, ground))
        {
            wps = true;
        }
    }
    private void Patrol()
    {
        if (!wps) Newalk();
        if (wps)
        {
            agent.SetDestination(wP);
        }
        Vector3 distanceToWalkPoint = transform.position - wP;
        if (distanceToWalkPoint.magnitude < 1f)
            wps = false;
    }
    private void Chase()
    {
        agent.SetDestination(ptrans.position);
    }
    private void Attack()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(ptrans);
        if (!attacked)
        {
            Rigidbody rb = Instantiate(eProj, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            attacked = true;
            Invoke(nameof(Rattack), attackTimer);
        }
    }
    private void Rattack()
    {
        attacked = false;
    }
    public void ETakeDamage(int damage)
    {
        ehealth -= damage;
        if (ehealth <= 0) Invoke(nameof(DestroyEnemy), .5f);
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
    private void TakeDamage()
    {
        inAnim = true;
        ehealth -= 1;
        gulp.PlayOneShot(hit);
        if (ehealth <= 0)
        {
            main.SetTrigger("Die");
            inAnim = true;
            agent.SetDestination(transform.position);
            Invoke(nameof(DestroyEnemy), 3.3f);
        }
        else
        {
            main.SetTrigger("React");
        }
    }
    IEnumerator Timer()
    {
        if (ehealth <= 0)
        {
            x = 3.3f;
        }
        yield return new WaitForSeconds(x);
        inAnim = false;
        main.SetTrigger("Walk");
    }
    private void OnTriggerEnter(Collider trigger)
    {

        if (ehealth > 0)
        {
            if (trigger.gameObject.tag == "pdmg")
            {
                inAnim = true;
                x = 1f;
                TakeDamage();
                agent.SetDestination(transform.position);
                StartCoroutine(Timer());
            }
            if (trigger.gameObject.tag == "prad")
            {
                inAnim = true;
                x = 4f;
                main.SetTrigger("Agony");
                agent.SetDestination(transform.position);
                StartCoroutine(Timer());
            }
            else if (trigger.gameObject.tag == "prad1")
            {
                x = 1f;
                TakeDamage();
                StartCoroutine(Timer());

            }
            else if (trigger.gameObject.tag == "prad3")
            {
                x = 1f;
                agent.SetDestination(transform.position);
                TakeDamage();
                StartCoroutine(Timer());
            }

        }
    }
}
