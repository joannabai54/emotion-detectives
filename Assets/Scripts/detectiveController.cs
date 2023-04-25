using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class detectiveController : MonoBehaviour
{
    public float moveSpeed;
    public Button leftArrow;
    public Button rightArrow;

    private bool isPressed = false;
    private Vector3 direction = Vector3.zero;
    private Animator animationController;

    // Start is called before the first frame update
    void Start()
    {
        animationController = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            transform.Translate(direction * moveSpeed * Time.deltaTime);

            if ((transform.position.x > 18f) || (transform.position.x < -5f))
            {
                transform.Translate(-1 * direction * moveSpeed * Time.deltaTime);
            }
            //Debug.Log("Sprite X: " + transform.position.x);
        }
    }

    public void MouseUp()
    {
        isPressed = false;
        // stop animation
        if (direction == Vector3.right)
        {
            animationController.SetBool("WalkingRight", false);
        }
        else if (direction == Vector3.left)
        {
            animationController.SetBool("WalkingLeft", false);
        }
    }

    public void MouseDown()
    {
        isPressed = true;

        GameObject selectedObject = EventSystem.current.currentSelectedGameObject;

        if (selectedObject == leftArrow.gameObject)
        {
            direction = Vector3.left;
            // animate walk left
            animationController.SetBool("WalkingLeft", true);
        }
        else if (selectedObject == rightArrow.gameObject)
        {
            direction = Vector3.right;
            // animate walk right
            animationController.SetBool("WalkingRight", true);
        }
    }
}
