using UnityEngine;

public class AnimatedDoorTrigger : MonoBehaviour
{
    private Animator[] childAnimators;

    private void Start()
    {
        // Automatically finds and stores the Animators on glass left, glass right, etc.
        childAnimators = GetComponentsInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Triggers open if the object or its parent structure is named "Player" or tagged "Player"
        if (other.CompareTag("Player") || other.name == "Player" || other.transform.root.name == "Player")
        {
            SetDoorsOpen(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Triggers close when leaving the zone
        if (other.CompareTag("Player") || other.name == "Player" || other.transform.root.name == "Player")
        {
            SetDoorsOpen(false);
        }
    }

    private void SetDoorsOpen(bool open)
    {
        foreach (Animator anim in childAnimators)
        {
            if (anim != null)
            {
                anim.SetBool("isOpen", open);
            }
        }
    }
}
