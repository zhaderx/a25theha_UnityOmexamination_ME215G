using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationScript : MonoBehaviour
{
    public InputActionAsset playerAction;
    public Animator playerAnimator;

    // Update is called once per frame
    void Update()
    {
        if (playerAction.FindAction("Move").IsPressed())
        {
            playerAnimator.SetBool("Walking", true);
        }
        else
            playerAnimator.SetBool("Walking", false);
    }
}
