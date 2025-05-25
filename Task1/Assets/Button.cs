using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator animationComponent;

    void HandleClick()
    {
        animationComponent.SetTrigger("Start");
    }

    void OnMouseDown()
    {
        HandleClick();
    }
}