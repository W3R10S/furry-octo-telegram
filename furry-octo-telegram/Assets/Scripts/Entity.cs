using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public int speed;
    public int health;
    public Vector2 atkCooldown;
    public float atkProjectileSpeed;

    public virtual void Attack() { }
    
    public virtual void Move() { }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
