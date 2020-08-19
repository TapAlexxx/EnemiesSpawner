using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class Monster : MonoBehaviour
{
    [SerializeField] private float _lifeTime;

    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger("Idle");

        Destroy(gameObject, _lifeTime);
    }
}
