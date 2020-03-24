using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]PlayerInput playerInput;
    [SerializeField] float moveSpeed;
    Vector2 moveAxis;

    [SerializeField] Animator anim;
    private void Start()
    {
       
        //var user = playerInput.user;
        //playerInput.SwitchCurrentControlScheme(Gamepad.current);

       
    }
    private void Update()
    {

        if (anim)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
           
                anim.SetTrigger("Junk");
            }
            else if (Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("Escape");

        }
        transform.Translate(new Vector3(moveAxis.x, 0, moveAxis.y) * moveSpeed * Time.deltaTime,Space.World);
    }
    public void Move(InputAction.CallbackContext ctx)
    {
    
        moveAxis = ctx.ReadValue<Vector2>();
  
       
    }
    public void Cast(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        Debug.Log("Cast "+ obj.phase);
    }
}
