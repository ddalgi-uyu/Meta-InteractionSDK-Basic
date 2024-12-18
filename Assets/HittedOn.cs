using UnityEngine;

public class HittedOn : MonoBehaviour
{
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint collisionContact = collision.GetContact(0);
        if (collisionContact.otherCollider.attachedRigidbody == null)
        {
            return;
        }

        Vector3 hitPosition = collisionContact.point;
        Vector3 hitForce = collisionContact.impulse / Time.fixedDeltaTime;
        Vector3 hitDirection = collisionContact.otherCollider.transform.forward;
        Vector3 moveDirection = new Vector3(hitDirection.x, 0, hitDirection.z);
        Vector3 hitPower = Vector3.Scale(hitForce, moveDirection);

        Debug.Log("Collision" + hitPower.ToString());

        collisionContact.thisCollider.attachedRigidbody.AddForceAtPosition(Vector3.Scale(hitDirection,hitForce), hitPosition, ForceMode.Impulse);
    }
}
