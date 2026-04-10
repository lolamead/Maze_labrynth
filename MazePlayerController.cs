using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MazePlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 checkPoint = new Vector3(-4.5f, 0.75f, 4.5f);
    public GameObject Floor;
    private int keyCount;
    public TMP_Text checkpointText;
    public TMP_Text keyText;
    public GameObject winUI;
    void Start()
    {
        keyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Restart();
        }
        if (Input.GetKey(KeyCode.R))
        {
            Restart();
        }
        Debug.Log(checkPoint);
    }

    void Restart()
    {
        transform.position = checkPoint;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        Floor.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            checkPoint = other.gameObject.transform.localPosition;
            setCheckpointText();
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Key")
        {
            checkPoint = other.gameObject.transform.localPosition;
            keyCount++;
            setKeyText();
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Enemy")
        {
            Restart();
        }
        if (other.gameObject.tag == "Finish")
        {
            if (keyCount == 2)
            {   
                other.gameObject.SetActive(false);
                winUI.SetActive(true);
            }
        }
    }

    void setCheckpointText()
    {
        checkpointText.text = "Checkpoint:√";
        checkpointText.color= new Color(121 / 255f, 191 / 255f, 255 / 255f, 255 / 255f);
    }

    void setKeyText()
    {
        if (keyCount == 1)
        {
            keyText.text = "Keys:√×";
        }else if (keyCount == 2)
        {
            keyText.text = "Keys:√√";
            keyText.color = new Color(0 / 255f, 132 / 255f, 255 / 255f, 255 / 255f);
        }
        
    }
}
