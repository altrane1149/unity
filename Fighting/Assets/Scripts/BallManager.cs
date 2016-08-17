using UnityEngine;
using UnityEngine.Assertions;
using System.Collections;

public class BallManager : MonoBehaviour {

    public Camera mainCamera;
    public GameObject ballPrefab;
    public Vector3 force = new Vector3(0, 0, 1000);

    private GameObject ballObjTmp;
    private Vector3 ballPosition;

    void Awake()
    {
        Assert.IsNotNull(ballPrefab, "ballPrefab is null");
    }

	void Start ()
    {
        ballPosition = mainCamera.GetComponent<Transform>().position + new Vector3(0, -0.5f, 2);
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ballObjTmp = GameObject.Instantiate(ballPrefab, ballPosition, Quaternion.identity) as GameObject;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            ballObjTmp.AddComponent<Rigidbody>();

            Rigidbody rb = ballObjTmp.GetComponent<Rigidbody>();
            rb.AddForce(force, ForceMode.Force);
        }
	}
}
