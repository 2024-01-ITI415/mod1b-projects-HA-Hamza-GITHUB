using UnityEngine;
using UnityEngine.UI;

public class ViewSwitch : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera topDownCamera;

    // Start is called before the first frame update
    void Start()
    {
        SetFirstPersonView();
    }

    // Switch between first-person and top-down views
    public void ToggleView()
    {
        Debug.Log("ToggleView called");
        if (firstPersonCamera.enabled)
        {   
            SetTopDownView();
        }
        else
        {
            SetFirstPersonView();
        }
    }

    // Set the first-person perspective view
    void SetFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        topDownCamera.enabled = false;
    }

    // Set the top-down 2D view
    void SetTopDownView()
    {
        firstPersonCamera.enabled = false;
        topDownCamera.enabled = true;
    }
}
