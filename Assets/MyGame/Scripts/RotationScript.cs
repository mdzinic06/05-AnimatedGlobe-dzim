using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RotationScript : MonoBehaviour
{
    public TMP_Text text_button_left;
    public TMP_Text text_button_right;

    public TMP_Text text_stop_rotation_left;

    public TMP_Text text_stop_rotation_right;

    public GameObject sphere;
    public float rotationSpeed = 100f;

    private bool rotateLeftActive = false;
    private bool rotateRightActive = false;

    void Start()
    {
        text_button_left.text = "Rotate Left";
        text_button_right.text = "Rotate Right";
        text_stop_rotation_left.text = "Stop rotation left";
        text_stop_rotation_right.text = "Stop rotation right";
    }

    public void StartRotateLeft()
    {
        rotateLeftActive = true;
    }

    public void StopRotateLeft()
    {
        rotateLeftActive = false;
    }

    public void StartRotateRight()
    {
        rotateRightActive = true;
    }

    public void StopRotateRight()
    {
        rotateRightActive = false;
    }

    void Update()
    {
        if (!rotateLeftActive && !rotateRightActive) return;

        float rotation = rotationSpeed * Time.deltaTime;

        if (rotateLeftActive)
        {
            sphere.transform.Rotate(Vector3.up, rotation, Space.World);
        }
        else if (rotateRightActive)
        {
            sphere.transform.Rotate(Vector3.up, -rotation, Space.World);
        }
    }
}
