using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Velocidad", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Saltando", true);
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void TocaPiso()
    {
        animator.SetBool("Saltando", false);
    }
}
