using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : Entity
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moving();
        
        roating();
    }

    public override void moving()
    {
        if (Input.GetKey(key: KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(key: KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else if (Input.GetKey(key: KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(key: KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void roating()
    {
        if (Input.GetKey(key: KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 5);
        }
        else if (Input.GetKey(key: KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, 5);
        }
    }

    private void onCollisionEnter(Collision other)
    {
        Entity otherEntity = other.gameObject.GetComponent<Entity>();
        if (otherEntity != null)
        {
            Damage(otherEntity.power);
        }
    }
}
