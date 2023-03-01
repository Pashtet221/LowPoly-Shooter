using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    
    [SerializeField] private float currentHeath;
    Ragdoll ragdoll;


    private void Start()
    {
        ragdoll = GetComponent<Ragdoll>();
        currentHeath = maxHealth;

        var rigidBodies = GetComponentsInChildren<Rigidbody>();
        foreach(var rigidBody in rigidBodies)
        {
          //  HitBox hitBox = rigidBody.gameObject.AddComponent<HitBox>();
          //  hitBox.health = this;
        }
    }


    public void TakeDamage(float amount)
    {
        currentHeath -= amount;
        if(currentHeath <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        ragdoll.ActivateRagdoll();
    }
}
