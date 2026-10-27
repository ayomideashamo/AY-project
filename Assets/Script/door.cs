using UnityEngine;

public class door : MonoBehaviour
{
    public Animator anim;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
            anim.SetBool("isOpen", true);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
            anim.SetBool("isOpen", false);
    }
}