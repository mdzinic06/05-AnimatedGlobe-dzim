using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RotationScript : MonoBehaviour
{
    public TMP_Text text_button_left;
    public TMP_Text text_button_right;

    public GameObject sphere;

    public float rotation_speed = 10;
    void Start()
    {
        text_button_left.text = "Rotate left";
        text_button_right.text = "Rotate right";
    }



    public void rotateLeft()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            sphere.transform.Rotate(Vector3.left * rotation_speed * Time.deltaTime);
        }
    }

    public void rotateRight()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            sphere.transform.Rotate(Vector3.right * rotation_speed * Time.deltaTime);
        }
    }


    void Update()
    {

    }
}
