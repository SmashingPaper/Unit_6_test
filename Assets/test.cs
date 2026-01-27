using UnityEngine;


public class test : MonoBehaviour
{
    private bool _testBool = true; 
    private Vector2 _transformTest;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetAxisRaw ("Horizontal");
    }
}
