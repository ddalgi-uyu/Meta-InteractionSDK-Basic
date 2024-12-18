using Oculus.Interaction.Input;
using UnityEngine;
using UnityEngine.Events;

public class YellowButtonSelected : MonoBehaviour
{
    public Transform rightHand;
    public Transform leftHand;

    public Material skinMaterial;
    public GameObject button;

    UnityEvent buttonSelectedEvent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (buttonSelectedEvent == null)
        {
            buttonSelectedEvent = new UnityEvent();
        }

        buttonSelectedEvent.AddListener(ChangeHandSkinTone);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeHandSkinTone()
    {
        rightHand.GetComponent<Renderer>().material = skinMaterial;
        leftHand.GetComponent<Renderer>().material = skinMaterial;
    }
}
